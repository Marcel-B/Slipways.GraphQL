using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using com.b_velop.Slipways.GrQl.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

namespace com.b_velop.Slipways.GrQl.Data.Repositories
{
    public class WaterRepository : RepositoryBase<Water>, IWaterRepository
    {
        public WaterRepository(
             SlipwaysContext db,
             IMemoryCache cache,
             ILogger<RepositoryBase<Water>> logger) : base(db, cache, logger)
        {
        }

        // This will be called by the loader for all pending keys
        // Note that fetch delegates can accept a CancellationToken parameter or not
        public async Task<IDictionary<Guid, Water>> GetWatersByIdAsync(
            IEnumerable<Guid> waterIds,
            CancellationToken cancellationToken)
        {
            var waters = await Db.Waters.ToListAsync();
            var result = new Dictionary<Guid, Water>();
            foreach (var water in waters)
            {
                if (waterIds.Contains(water.Id))
                    result[water.Id] = water;
            }
            return result;
        }
    }
}
