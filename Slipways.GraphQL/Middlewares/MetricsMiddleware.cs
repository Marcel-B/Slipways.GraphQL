using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Prometheus;

namespace com.b_velop.Slipways.GraphQL.Middlewares
{
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
            using (Metrics.CreateHistogram($"slipways_gql_duration_{httpContext.Request.Method}_seconds", "Histogram").NewTimer())
            {
                await  _next(httpContext);
            }
        }
    }

    public static class MetricsMiddlewareExtensions
    {
        public static IApplicationBuilder UseMetricsMiddleware(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MetricsMiddleware>();
        }
    }
}
