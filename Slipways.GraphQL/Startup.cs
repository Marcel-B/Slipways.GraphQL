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
using com.b_velop.Slipways.Data.Contracts;
using com.b_velop.Slipways.Data.Repositories;
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
            var cache = Environment.GetEnvironmentVariable("CACHE");
            services.AddSlipwaysData(cache);

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

            services.AddDbContext<SlipwaysContext>(options =>
            {
                var secretProvider = new SecretProvider();

                var port = Environment.GetEnvironmentVariable("PORT");
                var server = Environment.GetEnvironmentVariable("SERVER");
                var user = Environment.GetEnvironmentVariable("USER");
                var database = Environment.GetEnvironmentVariable("DATABASE");

                var pw = string.Empty;

                if (WebHostEnvironment.IsStaging())
                {
                    pw = secretProvider.GetSecret("dev_slipway_db");
                }
                else if (WebHostEnvironment.IsProduction())
                {
                    pw = secretProvider.GetSecret("sqlserver");
                }
                else
                {
                    pw = "foo123bar!";
                }

                var str = $"Server={server},{port};Database={database};User Id={user};Password={pw}";
#if DEBUG
                str = $"Server=db,1433;Database=Slipways;User Id=sa;Password=foo123bar!";
#endif
                options.UseSqlServer(str);
            });
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
