using com.b_velop.Slipways.GrQl.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace com.b_velop.Slipways.GrQl.Data.Repositories
{
    public interface IWaterRepository : ICachedRepositoryBase<Water>
    {
        // This will be called by the loader for all pending keys
        // Note that fetch delegates can accept a CancellationToken parameter or not
        Task<IDictionary<Guid, Water>> GetWatersByIdAsync(IEnumerable<Guid> waterIds, CancellationToken cancellationToken);
    }
}