using System;
using com.b_velop.Slipways.GrQl.Data.GraphQLSchema;
using com.b_velop.Slipways.GraphQL.Middlewares;
using GraphQL;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Prometheus;
using GraphQL.DataLoader;
using com.b_velop.Slipways.Data;
using com.b_velop.Slipways.GrQl.Infrastructure;
using com.b_velop.Slipways.Data.Extensions;

namespace com.b_velop.Slipways.GrQl
{
    public class Startup
    {
        public Startup(
            IConfiguration configuration,
            IWebHostEnvironment env)
        {
            Configuration = configuration;
            WebHostEnvironment = env;
        }

        public IConfiguration Configuration { get; }
        public IWebHostEnvironment WebHostEnvironment { get; }

        public void ConfigureServices(
            IServiceCollection services)
        {
            services.AddControllers();

            services.AddScoped<IDependencyResolver>(s => new FuncDependencyResolver(s.GetRequiredService));
            services.AddSingleton<IDataLoaderContextAccessor, DataLoaderContextAccessor>();
            services.AddSingleton<DataLoaderDocumentListener>();
            services.AddScoped<AppSchema>();

            services.AddGraphQL(options =>
            {
                options.ExposeExceptions = true;
                options.EnableMetrics = true;
            })
               .AddWebSockets()
               .AddDataLoader()
               .AddGraphTypes(ServiceLifetime.Scoped);

            var secretProvider = new SecretProvider();

            var port = Environment.GetEnvironmentVariable("PORT");
            var server = Environment.GetEnvironmentVariable("SERVER");
            var user = Environment.GetEnvironmentVariable("USER");
            var database = Environment.GetEnvironmentVariable("DATABASE");

            var password = string.Empty;

            if (WebHostEnvironment.IsStaging())
            {
                password = secretProvider.GetSecret("dev_slipway_db");
            }
            else if (WebHostEnvironment.IsProduction())
            {
                password = secretProvider.GetSecret("sqlserver");
            }
            else
            {
                password = "foo123bar!";
            }

            var str = $"Server={server},{port};Database={database};User Id={user};Password={password}";
#if DEBUG
            str = $"Server=localhost,1433;Database=Slipways;User Id=sa;Password=foo123bar!";
#endif
            services.AddSlipwaysData(str);

            services.Configure<KestrelServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });
        }

        public void Configure(
            IApplicationBuilder app,
            IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            app.UseWebSockets();
            app.UseMetricServer();
            app.UseHttpMetrics();
            app.UseMetricsMiddleware();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapMetrics();
            });

            app.UseGraphQL<AppSchema>("/graphql");
            app.UseGraphQLPlayground(options: new GraphQLPlaygroundOptions());
        }
    }
}
