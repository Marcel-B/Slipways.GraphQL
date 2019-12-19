using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using com.b_velop.Slipways.GrQl.Data.Models;

namespace com.b_velop.Slipways.GrQl.Data.Repositories
{
    public interface IManufacturerRepository : ICachedRepositoryBase<Manufacturer>
    {
        Task<ILookup<Guid, Manufacturer>> GetManufacturerByServiceIdAsync(IEnumerable<Guid> serviceIds, CancellationToken cancellationToken);
    }
}
