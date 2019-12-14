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
    public class StationRepository : CachedRepositoryBase<Station>, IStationRepository
    {
        public StationRepository(
            SlipwaysContext db,
            IMemoryCache cache,
            ILogger<RepositoryBase<Station>> logger) : base(db, cache, logger)
        {
            Key = Cache.Stations;
        }

        public async Task<IEnumerable<Station>> SelectIncludeAllAsync()
        {
            if (!_cache.TryGetValue(Cache.Stations, out IEnumerable<Station> stations))
            {
                stations = await Db.Stations.Include(_ => _.Water).ToListAsync();
                _cache.Set(Cache.Stations, stations);
            }
            return stations;
        }

        public async Task<ILookup<Guid, Station>> GetStationsByWaterIdAsync(
             IEnumerable<Guid> waterIds,
             CancellationToken cancellationToken)
        {
            var stations = await SelectAllAsync();
            var result = stations.Where(_ => waterIds.Contains(_.WaterFk));
            return result.ToLookup(x => x.WaterFk);
        }

        public async Task<Station> SelectByIdIncludeAsync(
            Guid id)
        {
            var stations = await SelectIncludeAllAsync();
            return stations.FirstOrDefault(_ => _.Id == id);
        }
    }
}
