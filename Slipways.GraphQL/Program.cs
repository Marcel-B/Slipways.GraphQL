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
            var file = string.Empty;
            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Staging")
                file = "dev-nlog.config";
            else
                file = "nlog.config";

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

                        var port = Environment.GetEnvironmentVariable("PORT");
                        var server = Environment.GetEnvironmentVariable("SERVER");
                        var user = Environment.GetEnvironmentVariable("USER");
                        var database = Environment.GetEnvironmentVariable("DATABASE");
                        var pw = string.Empty;

                        if (hostingContet.HostingEnvironment.IsStaging())
                        {
                            pw = secretProvider.GetSecret("dev_slipways_db");
                        }
                        else if (hostingContet.HostingEnvironment.IsProduction())
                        {
                            pw = secretProvider.GetSecret("sqlserver");
                        }
                        else
                        {
                            pw = "foo123bar!";
                        }

                        var str = $"Server={server},{port};Database={database};User Id={user};Password={pw}";
#if DEBUG
                        str = $"Server=localhost,1433;Database=Slipways;User Id=sa;Password={pw}";
#endif
                        services.AddDbContext<SlipwaysContext>(_ => _.UseSqlServer(str), ServiceLifetime.Transient);
                    })
                .UseNLog();
    }
}
