using com.b_velop.Slipways.GrQl.Data.Models;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

namespace com.b_velop.Slipways.GrQl.Data.Repositories
{
    public class ExtraRepository : RepositoryBase<Extra>, IExtraRepository
    {
        public ExtraRepository(
            SlipwaysContext db,
            IMemoryCache cache,
            ILogger<RepositoryBase<Extra>> logger) : base(db, cache, logger)
        {
        }
    }
}
