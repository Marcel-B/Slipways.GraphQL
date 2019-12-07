using System.Collections.Generic;
using System.Threading.Tasks;
using com.b_velop.Slipways.GrQl.Data.Models;
using com.b_velop.Slipways.GrQl.Infrastructure;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

namespace com.b_velop.Slipways.GrQl.Data.Repositories
{
    public class ManufacturerRepository : CachedRepositoryBase<Manufacturer>, IManufacturerRepository
    {
        public ManufacturerRepository(
            SlipwaysContext db,
            IMemoryCache cache,
            ILogger<RepositoryBase<Manufacturer>> logger) : base(db, cache, logger) { }

        public override async Task<IEnumerable<Manufacturer>> SelectAllAsync()
        {
            if (!_cache.TryGetValue(Cache.Manufacturer, out IEnumerable<Manufacturer> manufacturers))
            {
                manufacturers = await base.SelectAllAsync();
                _cache.Set(Cache.Manufacturer, manufacturers);
            }
            return manufacturers;
        }
    }
}
