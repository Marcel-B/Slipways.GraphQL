using com.b_velop.Slipways.GrQl.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace com.b_velop.Slipways.GrQl.Data.Repositories
{
    public interface IStationRepository : IRepositoryBase<Station>
    {
        Task<IEnumerable<Station>> SelectIncludeAllAsync();
        Task<Station> SelectByIdIncludeAsync(Guid id);
    }
}
