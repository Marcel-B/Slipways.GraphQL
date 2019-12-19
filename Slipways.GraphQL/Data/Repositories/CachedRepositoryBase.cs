using com.b_velop.Slipways.GrQl.Data.Models;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.b_velop.Slipways.GrQl.Data.Repositories
{

    public interface ICachedRepositoryBase<T> : IRepositoryBase<T> { }

    public class CachedRepositoryBase<T> : RepositoryBase<T>, ICachedRepositoryBase<T> where T : class, IEntity, new()
    {
        protected IMemoryCache _cache;
        protected string Key { get; set; }

        public CachedRepositoryBase(
            SlipwaysContext db,
            IMemoryCache cache,
            ILogger<RepositoryBase<T>> logger) : base(db, logger)
        {
            _cache = cache;
        }

        public override async Task<T> InsertAsync(
            T entity)
        {
            var result = await base.InsertAsync(entity);
            if (_cache.TryGetValue(Key, out IEnumerable<T> values))
            {
                var newValues = values.ToList();
                newValues.Add(result);
                _logger.LogInformation($"Add entity '{entity.Id}' to cache {typeof(T)}");
                _cache.Set(Key, newValues);
            }
            return result;
        }

        public override T Update(
            T entity)
        {
            var result = base.Update(entity);

            if (result == null)
                return null;

            if (_cache.TryGetValue(Key, out IEnumerable<T> values))
            {
                var tmp = values.FirstOrDefault(_ => _.Id == entity.Id);
                var newValues = values.ToList();

                newValues.Remove(tmp);
                newValues.Add(result);
                _logger.LogInformation($"Updated entity '{entity.Id}' in cache {typeof(T)}");
                _cache.Set(Key, newValues);
            }
            return result;
        }

        public override async Task<T> DeleteAsync(
            Guid id)
        {
            var result = await base.DeleteAsync(id);

            if (result == null)
                return null;

            if (_cache.TryGetValue(Key, out IEnumerable<T> values))
            {
                var newValues = values.ToList();
                newValues.Remove(result);
                _cache.Set(Key, newValues);
                _logger.LogInformation($"Removed entity '{id}' from cache {typeof(T)}");
            }
            return result;
        }
    }
}
