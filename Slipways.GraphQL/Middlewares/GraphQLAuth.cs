using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace com.b_velop.Slipways.GraphQL.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class GraphQLAuth
    {
        private readonly RequestDelegate _next;

        public GraphQLAuth(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext, IAuthorizationService authorizationService)
        {
            if (httpContext.Request.Path.StartsWithSegments("/graphql")
                && string.Equals(httpContext.Request.Method, "POST", StringComparison.OrdinalIgnoreCase))
            {
                AuthorizationResult authorizationResult =
                    await authorizationService.AuthorizeAsync(httpContext.User, null, "myPolicy");
                if (authorizationResult.Succeeded)
                    await _next(httpContext);
                else
                {
                    httpContext.Response.StatusCode = 401;
                    using (var bw = httpContext.Response.Body)
                        bw.Write(null);
                    await _next(httpContext);
                }
            }
            else
            {
                await _next(httpContext);
            }
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
