using System;
using com.b_velop.Slipways.GrQl.Data;
using com.b_velop.Slipways.GrQl.Data.GraphQLSchema;
using com.b_velop.Slipways.GrQl.Data.Repositories;
using com.b_velop.Slipways.GraphQL.Middlewares;
using com.b_velop.Slipways.GrQl.Services;
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
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Authorization;
using IdentityServer4.AccessTokenValidation;
using GraphQL.DataLoader;

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
            services.AddMemoryCache();

            services.AddHttpClient<IWsvService, WsvService>(_ =>
            {
                _.BaseAddress = new Uri("https://www.pegelonline.wsv.de");
                _.Timeout = TimeSpan.FromSeconds(10);
            });

            var authority = Environment.GetEnvironmentVariable("AUTHORITY");
            var apiResource = Environment.GetEnvironmentVariable("API_RESOURCE");

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

            services.AddScoped<IWaterRepository, WaterRepository>();
            services.AddScoped<IStationRepository, StationRepository>();
            services.AddScoped<ISlipwayRepository, SlipwayRepository>();
            services.AddScoped<IExtraRepository, ExtraRepository>();
            services.AddScoped<IServiceRepository, ServiceRepository>();
            services.AddScoped<IManufacturerRepository, ManufacturerRepository>();
            services.AddScoped<IManufacturerServicesRepository, ManufacturerServicesRepository>();
            services.AddScoped<IPortRepository, PortRepository>();
            services.AddScoped<ISlipwayExtraRepository, SlipwayExtraRepository>();
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();

            services.AddHostedService<CacheLoader>();
            services.AddHostedService<BackupService>();

            services.AddSwaggerGen(_ =>
            {
                _.SwaggerDoc(name: "v2", new OpenApiInfo { Title = "Slipway API", Version = "v2" });
            });
            services.Configure<KestrelServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });

            services.AddControllers();
            services.AddAuthorization(options =>
            {
                options.AddPolicy("reader", builder =>
                {
                    builder.RequireScope("slipways.api.reader");
                });
                options.AddPolicy("allin", builder =>
                {
                    builder.RequireScope("slipways.api.allaccess");
                });
            });

            services.AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme)
            .AddIdentityServerAuthentication(options =>
            {
                // base-address of your identityserver
                options.Authority = authority;
                options.RequireHttpsMetadata = true;
                // name of the API resource
                options.ApiName = apiResource;
            });

        }

        public void Configure(
            IApplicationBuilder app,
            IWebHostEnvironment env)
        {
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseWebSockets();

            app.UseMetricServer();
            app.UseHttpMetrics();
            app.UseMetricsMiddleware();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(_ =>
            {
                _.SwaggerEndpoint(url: "/swagger/v2/swagger.json", name: "Slipways API v2");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            // use HTTP middleware for ChatSchema at path /graphql
            app.UseGraphQL<AppSchema>("/graphql");
            app.UseGraphQLPlayground(options: new GraphQLPlaygroundOptions());
        }
    }
}
