using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using com.b_velop.Slipways.Data;
using com.b_velop.Slipways.Data.Contracts;
using com.b_velop.Slipways.GrQl.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace com.b_velop.Slipways.GrQl.Infrastructure
{
    public class Initializer : IInitializer
    {
        private IMemoryCache _memoryCache;
        private SlipwaysContext _context;
        private ILogger<Initializer> _logger;

        public Initializer(
            SlipwaysContext context,
            IMemoryCache memoryCache,
            ILogger<Initializer> logger)
        {
            _memoryCache = memoryCache;
            _context = context;
            _logger = logger;
        }

        public async Task InitDatabase<T>(
            string path,
            string name) where T : class, IEntity
        {
            var json = File.ReadAllText(path);
            var objects = JsonConvert.DeserializeObject<IEnumerable<T>>(json);
            var all = await _context.Set<T>().ToListAsync();
            var targets = new List<T>();
            foreach (var obj in objects)
            {
                var value = all.FirstOrDefault(_ => _.Id == obj.Id);
                if (value == null)
                    targets.Add(obj);
            }
            await _context.Set<T>().AddRangeAsync(targets);
            _context.SaveChanges();
        }

        public async Task InitCache<T>(
            string name) where T : class, IEntity
        {
            try
            {
                //_logger.LogInformation($"Init cache for '{name}'");
                var all = await _context.Set<T>().ToListAsync();
                //_logger.LogInformation($"Got '{all.Count}' values for '{name}'");
                _memoryCache.Set(name, all.ToHashSet());
            }
            catch (Exception e)
            {
                _logger.LogError(6666, $"Unexpected error occurred while initialize Cache for '{name}'", e);
            }
        }
    }
}
