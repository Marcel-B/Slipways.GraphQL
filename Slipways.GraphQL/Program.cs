using System;
using com.b_velop.Slipways.GrQl.Data;
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
        private static NLog.Logger logger;
        public static void Main(string[] args)
        {
            var file = "nlog.config";
            var metricPusher = new MetricPusher(new MetricPusherOptions
            {
                Endpoint = "https://push.qaybe.de/metrics",
                Job = "slipwaysql",
                Instance = Environment.MachineName
            });

            metricPusher.Start();

            logger = NLogBuilder.ConfigureNLog(file).GetCurrentClassLogger();
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
                .ConfigureServices((hostingContet, services) =>
                    {
                        var secretProvider = new SecretProvider();
                        var pw = secretProvider.GetSecret("sqlserver");
                        var str = $"Server=sqlserver,1433;Database=Slipways;User Id=sa;Password={pw}";
#if DEBUG
                        str = "Server=localhost,1433;Database=Slipways;User Id=sa;Password=foo123bar!";
#endif
                        services.AddDbContext<SlipwaysContext>(_ => _.UseSqlServer(str), ServiceLifetime.Transient);
                    })
                .UseNLog();
    }
}
