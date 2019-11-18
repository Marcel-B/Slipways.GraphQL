using System;
using com.b_velop.Slipways.GraphQL.Data.Models;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

namespace com.b_velop.Slipways.GraphQL.Data.Repositories
{
    public class WaterRepository : RepositoryBase<Water>, IWaterRepository
    {
        public WaterRepository(
             SlipwaysContext db,
             IMemoryCache cache,
             ILogger<RepositoryBase<Water>> logger) : base(db, cache, logger)
        {
        }


    }
}
