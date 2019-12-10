using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using com.b_velop.Slipways.GrQl.Data.Models;

namespace com.b_velop.Slipways.GrQl.Data.Repositories
{
    public interface IServiceRepository : IRepositoryBase<Service>
    {
        Task<IEnumerable<Service>> GetAllIncludeAsync();
        Task<ILookup<Guid, Service>> GetServicesByManufacturerIdAsync(IEnumerable<Guid> manufacturerIds, CancellationToken cancellationToken);
    }
}
