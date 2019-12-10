using com.b_velop.Slipways.GrQl.Data.Models;
using Microsoft.Extensions.Logging;

namespace com.b_velop.Slipways.GrQl.Data.Repositories
{
    public interface ISlipwayExtraRepository : IRepositoryBase<SlipwayExtra> { }
    public class SlipwayExtraRepository : RepositoryBase<SlipwayExtra>, ISlipwayExtraRepository
    {
        public SlipwayExtraRepository(SlipwaysContext db, ILogger<RepositoryBase<SlipwayExtra>> logger) : base(db, logger)
        {
        }
    }
}
