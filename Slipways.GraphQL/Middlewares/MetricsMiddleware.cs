using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Prometheus;

namespace com.b_velop.Slipways.GraphQL.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class MetricsMiddleware
    {
        private readonly ILogger<MetricsMiddleware> _logger;
        private readonly RequestDelegate _next;

        public MetricsMiddleware(
            RequestDelegate next,
            ILogger<MetricsMiddleware> logger)
        {
            _logger = logger;
            _next = next;
        }

        public async Task Invoke(
            HttpContext httpContext)
        {
            //using (var reader = new StreamReader(httpContext.Request.Body))
            //{
            //    var result = await reader.ReadToEndAsync();
            //}
            using (Metrics.CreateHistogram($"slipwaysql_duration_{httpContext.Request.Method}_seconds", "Histogram").NewTimer())
            {
                await  _next(httpContext);
            }
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MetricsMiddlewareExtensions
    {
        public static IApplicationBuilder UseMetricsMiddleware(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MetricsMiddleware>();
        }
    }
}
