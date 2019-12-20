using com.b_velop.Slipways.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Security;
using System.Text.Json;
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

            _timer = new Timer(DoWork, null, TimeSpan.FromMinutes(15),
                TimeSpan.FromDays(1));
            return Task.CompletedTask;
        }

        private async void DoWork(
            object state)
        {
            try
            {
                using var scope = _services.CreateScope();
                _logger?.LogInformation("Backup Database");
                var ctx = scope.ServiceProvider.GetRequiredService<SlipwaysContext>();
                var slipways = await ctx.Slipways.ToListAsync();
                var dir = new DirectoryInfo("./backUp");
                if (!dir.Exists)
                    dir.Create();
                var slipwaysJson = JsonSerializer.Serialize(slipways, new JsonSerializerOptions { WriteIndented = false, IgnoreNullValues = true });
                await File.WriteAllTextAsync("./backUp/slipways.json", slipwaysJson.ToString());
            }
            catch (JsonException e)
            {
                _logger?.LogError(6666, "Error occurred while Serialize object", e);
            }
            catch(InvalidOperationException e)
            {
                _logger?.LogError(6666, "Error occurred while get Required Service", e);
            }
            catch(ArgumentNullException e)
            {
                _logger?.LogError(6666, "Error occurred whith Directory", e);
            }
            catch (SecurityException e)
            {
                _logger?.LogError(6666, "Error occurred whith Directory ", e);
            }
            catch (ArgumentException e)
            {
                _logger?.LogError(6666, "Error occurred whith Directory", e);
            }
            catch (Exception e)
            {
                _logger?.LogError(6666, "Error occurred while BackUp database", e);
            }
        }

        public Task StopAsync(
            CancellationToken stoppingToken)
        {
            _logger?.LogInformation("CacheLoader Service is stopping.");
            _timer?.Change(Timeout.Infinite, 0);
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}