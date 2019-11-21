using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using com.b_velop.Slipways.GraphQL.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

namespace com.b_velop.Slipways.GraphQL.Data.Repositories
{
    public class StationRepository : RepositoryBase<Station>, IStationRepository
    {
        public StationRepository(
            SlipwaysContext db,
            IMemoryCache cache,
            ILogger<RepositoryBase<Station>> logger) : base(db, cache, logger)
        {
        }


        public async Task<IEnumerable<Station>> SelectIncludeAllAsync()
            => await Db.Stations.Include(_ => _.Water).ToListAsync();

        public async Task<Station> SelectByIdIncludeAsync(
            Guid id)
            => await Db
                .Stations
                .Include(_ => _.Water)
                .FirstOrDefaultAsync(_ => _.Id == id);
    }
}
