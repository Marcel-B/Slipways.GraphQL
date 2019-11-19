using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using com.b_velop.Slipways.GraphQL.Data.Models;

namespace com.b_velop.Slipways.GraphQL.Data.Repositories
{
    public interface IStationRepository : IRepositoryBase<Station>
    {
        Task<IEnumerable<Station>> SelectIncludeAllAsync();
        Task<Station> SelectIncludeAsync(Guid id);
    }
}
