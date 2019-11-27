using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using com.b_velop.Slipways.GrQl.Data;
using com.b_velop.Slipways.GrQl.Data.GraphQLSchema;
using com.b_velop.Slipways.GrQl.Data.Repositories;
using com.b_velop.Slipways.GraphQL.Middlewares;
using com.b_velop.Slipways.GrQl.Services;
using GraphQL;
using GraphQL.Server;
using GraphQL.Server.Transports.AspNetCore;
using GraphQL.Server.Transports.AspNetCore.Internal;
using GraphQL.Server.Ui.Playground;
using GraphQL.Validation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Prometheus;
using GraphQL.Core.Authorization;

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
            //JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();

            services.AddHttpClient<IWsvService, WsvService>(_ =>
            {
                _.BaseAddress = new Uri("https://www.pegelonline.wsv.de");
                _.Timeout = TimeSpan.FromSeconds(10);
            });

            var authority = Environment.GetEnvironmentVariable("AUTHORITY");
            var apiResource = Environment.GetEnvironmentVariable("API_RESOURCE");


            //services.AddAuthentication("Bearer")
            //    .AddIdentityServerAuthentication(options =>
            //    {
            //        options.Authority = authority;
            //        // if (WebHostEnvironment.IsDevelopment())
            //        //     options.RequireHttpsMetadata = false;
            //        // else
            //        options.RequireHttpsMetadata = true;
            //        options.ApiName = apiResource;
            //    });

            services.AddScoped<IDependencyResolver>(s => new FuncDependencyResolver(s.GetRequiredService));
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
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
            //services.AddScoped<AppQuery>()
            //    .AddScoped<AppMutation>()
            //    .AddScoped<AppSchema>()
            //    .AddScoped<SlipwayInputType>()
            //    .AddScoped<SlipwayType>()
            //    .AddScoped<StationType>()
            //    .AddScoped<WaterType>();

            //services.AddSwaggerGen(_ =>
            //{
            //    _.SwaggerDoc(name: "v1", new OpenApiInfo { Title = "Slipway API", Version = "v1" });
            //});
            services.Configure<KestrelServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });

            services.AddControllers();

            //services.AddMvcCore(options =>
            //{
            //    var policy = ScopePolicy.Create("slipways.writer");
            //    options.Filters.Add(new AuthorizeFilter(policy));
            //}).AddAuthorization(options =>
            //{
            //    options.AddPolicy("myPolicy", builder =>
            //    {
            //        builder.RequireScope("slipways.writer");
            //    });
            //});

            //services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            //      .AddJwtBearer(options =>
            //      {
            //          // base-address of your identityserver
            //          options.Authority = authority;

            //          // name of the API resource
            //          options.Audience = apiResource;
            //      });
        }

        public void Configure(
            IApplicationBuilder app,
            IWebHostEnvironment env)
        {
            app.UseRouting();

            //app.UseAuthentication();
            //app.UseAuthorization();
            // this is required for websockets support
            //app.UseWebSockets();

            app.UseMetricServer();
            app.UseHttpMetrics();
            app.UseMetricsMiddleware();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseSwagger();
            //app.UseSwaggerUI(_ =>
            //{
            //    _.SwaggerEndpoint(url: "/swagger/v1/swagger.json", name: "Slipways API v1");
            //});
            UpdateDatabase(app);


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                //.RequireAuthorization("myPolicy");
            });

            // use HTTP middleware for ChatSchema at path /graphql
            //app.UseGraphQL<AppSchema>("/graphql");
            app.UseGraphQLPlayground(options: new GraphQLPlaygroundOptions());
        }

        private static void UpdateDatabase(IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices
                .GetRequiredService<IServiceScopeFactory>()
                .CreateScope();
            using var context = serviceScope.ServiceProvider.GetService<SlipwaysContext>();
            context.Database.Migrate();
        }
    }


    public static class GraphQLAuthExtensions
    {
        public static void AddGraphQLAuth(this IServiceCollection services, Action<AuthorizationSettings> configure)
        {
            //services.AddScoped<IHttpContextAccessor, HttpContextAccessor>();
            //services.AddScoped</*IAuthorizationEvaluator,*/ AuthorizationEvaluator>();
            //services.AddScoped<IValidationRule, AuthorizationValidationRule>();

            services.AddScoped<IUserContextBuilder>(s => new UserContextBuilder<GraphQLUserContext>(context =>
            {
                var userContext = new GraphQLUserContext
                {
                    User = context.User
                };

                return Task.FromResult(userContext);
            }));

            services.AddSingleton(s =>
            {
                var authSettings = new AuthorizationSettings();
                configure(authSettings);
                return authSettings;
            });
        }
    }

    public class GraphQLUserContext : IProvideClaimsPrincipal
    {
        public ClaimsPrincipal User { get; set; }
    }

    public class MapRolesForGraphQLMiddleware
    {
        private readonly RequestDelegate _next;

        public MapRolesForGraphQLMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            // custom mapping code to end up with a "Role" claim
            var metadata = context.User.Claims.SingleOrDefault(x => x.Type.Equals("metadata"));

            if (metadata != null)
            {
                var roleContainer = JsonConvert.DeserializeObject<RoleContainer>(metadata.Value);
                (context.User.Identity as ClaimsIdentity).AddClaim(new Claim("Role", string.Join(", ", roleContainer.Roles)));
            }

            await _next(context);
        }
    }

    public class RoleContainer
    {
        public String[] Roles { get; set; }
    }
}
