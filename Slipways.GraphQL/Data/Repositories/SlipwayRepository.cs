using com.b_velop.Slipways.GraphQL.Data.Models;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

namespace com.b_velop.Slipways.GraphQL.Data.Repositories
{
    public class SlipwayRepository : RepositoryBase<Slipway>, ISlipwayRepository
    {
        public SlipwayRepository(
            SlipwaysContext db,
            IMemoryCache cache,
            ILogger<RepositoryBase<Slipway>> logger) : base(db, cache, logger)
        {
        }
    }
}
