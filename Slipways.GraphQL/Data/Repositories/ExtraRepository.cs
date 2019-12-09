using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using com.b_velop.Slipways.GrQl.Data.Models;
using com.b_velop.Slipways.GrQl.Infrastructure;
using Microsoft.EntityFrameworkCore;
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
            if (!_cache.TryGetValue(Cache.Extras, out IEnumerable<Extra> extras))
            {
                extras = await base.SelectAllAsync();
                _cache.Set(Cache.Extras, extras);
            }
            return extras;
        }

        public async Task<ILookup<Guid, Extra>> GetExtrasBySlipwayIdAsync(
            IEnumerable<Guid> slipwaysIds,
            CancellationToken cancellationToken)
        {
            var extras = await SelectAllAsync();
            var extraIds = Db.SlipwayExtras.Where(_ => slipwaysIds.Contains(_.SlipwayFk));
            var result = new Dictionary<Guid,Extra>();

            foreach (var id in extraIds)
            {
                var extra = extras.FirstOrDefault(_ => _.Id == id.ExtraFk);
                result[id.SlipwayFk] = extra;
            }
            return result.ToLookup(_ => _.Key, _ => _.Value);
        }
    }
}
