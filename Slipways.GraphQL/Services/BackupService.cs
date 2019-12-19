using com.b_velop.Slipways.GrQl.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace com.b_velop.Slipways.GrQl.Services
{
    public class BackupService : IHostedService, IDisposable
    {
        private readonly IServiceProvider _services;
        private readonly ILogger<BackupService> _logger;
        private Timer _timer;

        public BackupService(
            IServiceProvider services,
            ILogger<BackupService> logger)
        {
            _services = services;
            _logger = logger;
        }
        public Task StartAsync(
            CancellationToken stoppingToken)
        {
            _logger.LogInformation("CacheLoader service running");

            _timer = new Timer(DoWork, null, TimeSpan.Zero,
                TimeSpan.FromDays(1));
            return Task.CompletedTask;
        }

        private async void DoWork(
            object state)
        {
            //try
            //{
            //    using var scope = _services.CreateScope();
            //    _logger.LogInformation("Backup Database");
            //    var ctx = scope.ServiceProvider.GetRequiredService<SlipwaysContext>();
            //    var slipways = await ctx.Slipways.ToListAsync();
            //    var sb = new StringBuilder();

            //    var dir = new DirectoryInfo("./backUp");
            //    if (!dir.Exists)
            //        dir.Create();

            //    sb.AppendLine($"Id;Name;Street;Postalcode;City;Longitude;Latitude;Costs;Pro;Contra;Comment;Rating;WaterFk;Created;Updated");
            //    foreach (var slipway in slipways)
            //    {
            //        sb.Append($"{slipway.Id};{slipway.Name};{slipway.Street};{slipway.Postalcode};{slipway.City};{slipway.Longitude};{slipway.Latitude};{slipway.Costs};{slipway.Pro ?? string.Empty};{slipway.Contra ?? string.Empty};{slipway.Comment?.Replace(';', '-') ?? string.Empty};{slipway.Rating};{slipway.WaterFk};{slipway.Created};");
            //        if (slipway.Updated == null) sb.AppendLine("");
            //        else sb.AppendLine($"{slipway.Updated}");
            //    }
            //    await File.WriteAllTextAsync("./backUp/slipways.csv", sb.ToString());
            //}
            //catch (Exception e)
            //{
            //    _logger.LogError(6666, "Error occurred while BackUp database", e);
            //}
        }

        public Task StopAsync(
            CancellationToken stoppingToken)
        {
            _logger.LogInformation("CacheLoader Service is stopping.");
            _timer?.Change(Timeout.Infinite, 0);
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}