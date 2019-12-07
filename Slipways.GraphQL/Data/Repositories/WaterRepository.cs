using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using com.b_velop.Slipways.GrQl.Data.Models;
using com.b_velop.Slipways.GrQl.Infrastructure;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

namespace com.b_velop.Slipways.GrQl.Data.Repositories
{
    public class WaterRepository : CachedRepositoryBase<Water>, IWaterRepository
    {
        public WaterRepository(
             SlipwaysContext db,
             IMemoryCache cache,
             ILogger<RepositoryBase<Water>> logger) : base(db, cache, logger)
        {
        }

        public override async Task<IEnumerable<Water>> SelectAllAsync()
        {
            if(!_cache.TryGetValue(Cache.Waters, out IEnumerable<Water> waters))
            {
                waters = await base.SelectAllAsync();
                _cache.Set(Cache.Waters, waters);
            }
            return waters;
        }
    }
}
