using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using com.b_velop.Slipways.GrQl.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

namespace com.b_velop.Slipways.GrQl.Data.Repositories
{
    public interface IServiceRepository : IRepositoryBase<Service> { }
    public class ServiceRepository : RepositoryBase<Service>,  IServiceRepository
    {
        public ServiceRepository(
            SlipwaysContext db,
            IMemoryCache cache,
            ILogger<RepositoryBase<Service>> logger) : base(db, cache, logger)
        {
        }

        public async Task<IEnumerable<Service>> GetAllIncludeAsync()
        {
            var services = await Db.Services.Include(_ => _.Manufacturers).ToListAsync();
            return services;
        }
    }
}
