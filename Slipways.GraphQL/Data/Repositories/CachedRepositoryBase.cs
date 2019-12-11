using com.b_velop.Slipways.GrQl.Data.Models;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.b_velop.Slipways.GrQl.Data.Repositories
{

    public interface ICachedRepositoryBase<T> : IRepositoryBase<T>
    {
    }

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
                _cache.Set(Key, newValues);
            }
            return result;
        }

        public override async Task<T> DeleteAsync(
            Guid id)
        {
            var result = await base.DeleteAsync(id);
            if (_cache.TryGetValue(Key, out IEnumerable<T> values))
            {
                var newValues = values.ToList();
                newValues.Remove(result);
                _cache.Set(Key, newValues);
            }
            return result;
        }
    }
}
