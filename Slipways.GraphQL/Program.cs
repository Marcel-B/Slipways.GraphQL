using System;
using com.b_velop.Slipways.Data;
using com.b_velop.Slipways.GrQl.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Web;
using Prometheus;

namespace com.b_velop.Slipways.GrQl
{
    public class Program
    {
        public static void Main(
            string[] args)
        {
            var file = "nlog.config";
            var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            if (env != "Production")
                file = "dev-nlog.config";
            var job = env == "Production" ? "SlipwaysGraphQL" : "DevSlipwaysGraphQL";


            var metricPusher = new MetricPusher(new MetricPusherOptions
            {
                Endpoint = "https://push.qaybe.de/metrics",
                Job = job,
                Instance = job
            });
            metricPusher.Start();

            var logger = NLogBuilder.ConfigureNLog(file).GetCurrentClassLogger();
            try
            {
                logger.Debug("init main");
                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Stopped program because of exception");
                throw;
            }
            finally
            {
                NLog.LogManager.Shutdown();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureLogging(logging =>
                    {
                        logging.ClearProviders();
                        logging.AddConsole();
                        logging.SetMinimumLevel(LogLevel.Trace);
                    })
                .ConfigureWebHostDefaults(webBuilder =>
                    {
                        webBuilder.UseStartup<Startup>();
                    })
                .UseNLog();
    }
}
