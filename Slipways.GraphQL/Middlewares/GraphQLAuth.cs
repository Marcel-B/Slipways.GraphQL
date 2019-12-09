using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.DataLoader;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace com.b_velop.Slipways.GraphQL.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class GraphQLAuth
    {
        private readonly IServiceProvider _services;
        private readonly RequestDelegate _next;

        public GraphQLAuth(
            IServiceProvider services,
            RequestDelegate next)
        {
            _services = services;
            _next = next;
        }

        public async Task Invoke(
            HttpContext httpContext)//,
            //IAuthorizationService authorizationService)
        {
            var listener = _services.GetRequiredService<DataLoaderDocumentListener>();
            var executer = new DocumentExecuter();
            var result = executer.ExecuteAsync(opts =>
            {
                opts.Listeners.Add(listener);
            });


            //if (httpContext.Request.Path.StartsWithSegments("/graphql")
            //    && string.Equals(httpContext.Request.Method, "POST", StringComparison.OrdinalIgnoreCase))
            //{
            //    AuthorizationResult authorizationResult =
            //        await authorizationService.AuthorizeAsync(httpContext.User, null, "myPolicy");
            //    if (authorizationResult.Succeeded)
            //    {
            //        await _next(httpContext);
            //    }
            //    else
            //    {
            //        httpContext.Response.StatusCode = 401;
            //        using (var bw = httpContext.Response.Body)
            //            bw.Write(null);
            //        await _next(httpContext);
            //    }
            //}
            //else
            //{
            await _next(httpContext);
            //}
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class GraphQLAuthExtensions
    {
        public static IApplicationBuilder UseGraphQLAuth(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<GraphQLAuth>();
        }
    }
}
