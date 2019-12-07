using System.Collections.Generic;
using System.Threading.Tasks;
using com.b_velop.Slipways.GrQl.Data.Models;
using com.b_velop.Slipways.GrQl.Infrastructure;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

namespace com.b_velop.Slipways.GrQl.Data.Repositories
{
    public class ExtraRepository : CachedRepositoryBase<Extra>, IExtraRepository
    {
        public ExtraRepository(
            SlipwaysContext db,
            IMemoryCache cache,
            ILogger<RepositoryBase<Extra>> logger) : base(db, cache, logger)
        {
        }

        public override async Task<IEnumerable<Extra>> SelectAllAsync()
        {
            if(!_cache.TryGetValue(Cache.Extras, out IEnumerable<Extra> extras))
            {
                extras = await base.SelectAllAsync();
                _cache.Set(Cache.Extras, extras);
            }
            return extras;
        }
    }
}
