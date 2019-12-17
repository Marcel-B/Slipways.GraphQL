using com.b_velop.Slipways.GrQl.Data.Models;
using Microsoft.Extensions.Logging;

namespace com.b_velop.Slipways.GrQl.Data.Repositories
{
    public interface IManufacturerServicesRepository : IRepositoryBase<ManufacturerService>
    {

    }
    public class ManufacturerServicesRepository : RepositoryBase<ManufacturerService>, IManufacturerServicesRepository
    {
        public ManufacturerServicesRepository(SlipwaysContext db, ILogger<RepositoryBase<ManufacturerService>> logger) : base(db, logger)
        {
        }
    }
}
