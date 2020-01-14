using System;
using System.Threading;
using System.Threading.Tasks;
using com.b_velop.Slipways.Data.Helper;
using com.b_velop.Slipways.Data.Models;
using com.b_velop.Slipways.GrQl.Contracts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace com.b_velop.Slipways.GrQl.Services
{
    public class CacheLoader : IHostedService
    {
        private readonly IServiceProvider _services;
        private readonly ILogger<CacheLoader> _logger;
        private Timer _timer;

        public CacheLoader(
            IServiceProvider services,
            ILogger<CacheLoader> logger)
        {
            _services = services;
            _logger = logger;
        }

        public Task StartAsync(
            CancellationToken stoppingToken)
        {
            _logger.LogInformation("CacheLoader service running");
            _timer = new Timer(DoWork, null, TimeSpan.FromSeconds(15), TimeSpan.FromMinutes(1));
            return Task.CompletedTask;
        }

        private async void DoWork(
            object state)
        {
            try
            {
                using var scope = _services.CreateScope();
                _logger.LogInformation("Reload cache");
                var initializer = scope.ServiceProvider.GetRequiredService<IInitializer>();

                await initializer.InitCache<Water>(Cache.Waters);
                await initializer.InitCache<SlipwayExtra>(Cache.SlipwayExtras);
                await initializer.InitCache<Slipway>(Cache.Slipways);
                await initializer.InitCache<Extra>(Cache.Extras);
                await initializer.InitCache<Station>(Cache.Stations);
                await initializer.InitCache<Manufacturer>(Cache.Manufacturers);
                await initializer.InitCache<ManufacturerService>(Cache.ManufacturerServices);
                await initializer.InitCache<Service>(Cache.Services);
                await initializer.InitCache<Port>(Cache.Ports);

                _logger.LogInformation("Reload cache done");
            }
            catch (InvalidOperationException e)
            {
                _logger.LogError(6665, $"Error while updating cache", e);
            }
            catch (Exception e)
            {
                _logger.LogError(6666, $"Unexpected error while updating cache", e);
            }
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