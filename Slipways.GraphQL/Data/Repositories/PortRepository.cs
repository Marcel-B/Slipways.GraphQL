using com.b_velop.Slipways.GrQl.Data.Models;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

namespace com.b_velop.Slipways.GrQl.Data.Repositories
{
    public interface IPortRepository : IRepositoryBase<Port> { }

    public class PortRepository : RepositoryBase<Port>, IPortRepository
    {
        public PortRepository(
            SlipwaysContext db,
            ILogger<RepositoryBase<Port>> logger) :
            base(db, logger)
        {
        }
    }
}
