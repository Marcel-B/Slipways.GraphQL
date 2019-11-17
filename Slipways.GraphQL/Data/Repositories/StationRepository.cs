using com.b_velop.Slipways.GraphQL.Data.Models;
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
    }
}
