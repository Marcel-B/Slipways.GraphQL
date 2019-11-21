using com.b_velop.Slipways.GraphQL.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace com.b_velop.Slipways.GraphQL.Data.Repositories
{
    public class SlipwayRepository : RepositoryBase<Slipway>, ISlipwayRepository
    {
        public SlipwayRepository(
            SlipwaysContext db,
            IMemoryCache cache,
            ILogger<RepositoryBase<Slipway>> logger) : base(db, cache, logger)
        {
        }

        public async Task<IEnumerable<Slipway>> SelectIncludeAllAsync()
            => await Db
                .Slipways
                .Include(_ => _.Water)
                .ToListAsync();

        public async Task<Slipway> SelectByIdIncludeAsync(
            Guid id)
            => await Db
                .Slipways
                .Include(_ => _.Water)
                .FirstOrDefaultAsync(_ => _.Id == id);
    }
}
