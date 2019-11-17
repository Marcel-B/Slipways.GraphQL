using System;
using com.b_velop.Slipways.GraphQL.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Web;

namespace com.b_velop.Slipways.GraphQL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var file = "nlog.config";

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
                .ConfigureServices((hostingContet, services) =>
                    {
                        var str = Environment.GetEnvironmentVariable("CON_STR");
#if DEBUG
                        str = "Server=localhost,1433;Database=Slipways;User Id=sa;Password=foo123bar!";
#endif
                        services.AddDbContext<SlipwaysContext>(_ => _.UseSqlServer(str));
                    })
                .UseNLog();
    }
}
