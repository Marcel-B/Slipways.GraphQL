using com.b_velop.Slipways.GraphQL.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace com.b_velop.Slipways.GraphQL.Data.Repositories
{
    public interface ISlipwayRepository : IRepositoryBase<Slipway>
    {
        Task<IEnumerable<Slipway>> SelectIncludeAllAsync();
        Task<Slipway> SelectByIdIncludeAsync(Guid id);
    }
}
