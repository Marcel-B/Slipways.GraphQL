﻿using System;
using System.Threading;
using System.Threading.Tasks;
using com.b_velop.Slipways.GrQl.Data.Repositories;
using com.b_velop.Slipways.GrQl.Infrastructure;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace com.b_velop.Slipways.GrQl.Services
{
    public class CacheLoader : IHostedService, IDisposable
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

            _timer = new Timer(DoWork, null, TimeSpan.Zero,
                TimeSpan.FromMinutes(1));
            return Task.CompletedTask;
        }

        private async void DoWork(
            object state)
        {
            using var scope = _services.CreateScope();
            _logger.LogInformation("Reload cache");
            var cache = scope.ServiceProvider.GetRequiredService<IMemoryCache>();
            var rep = scope.ServiceProvider.GetRequiredService<IRepositoryWrapper>();
            var waters = await rep.Water.SelectAllAsync();
            cache.Set(Cache.Waters, waters);
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