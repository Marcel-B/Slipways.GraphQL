using com.b_velop.Slipways.GrQl.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace com.b_velop.Slipways.GrQl.Data.Repositories
{
    public interface ISlipwayRepository : IRepositoryBase<Slipway>
    {
        Task<IEnumerable<Slipway>> SelectIncludeAllAsync();
        Task<Slipway> SelectByIdIncludeAsync(Guid id);
        Task<IEnumerable<Slipway>> SelectByExtraIdAsync(Guid extraId);
        Task<ILookup<Guid, Slipway>> GetSlipwayByWaterIdAsync(IEnumerable<Guid> waterIds, CancellationToken cancellationToken);
        Task<ILookup<Guid, Slipway>> GetSlipwaysByExtraIdAsync(IEnumerable<Guid> extraIds, CancellationToken cancellationToken);
    }
}