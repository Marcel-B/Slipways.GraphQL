using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using com.b_velop.Slipways.GrQl.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

namespace com.b_velop.Slipways.GrQl.Data.Repositories
{
    public class ServiceRepository : RepositoryBase<Service>, IServiceRepository
    {
        public ServiceRepository(
            SlipwaysContext db,
            IMemoryCache cache,
            ILogger<RepositoryBase<Service>> logger) : base(db, cache, logger)
        { }

        public async Task<IEnumerable<Service>> GetAllIncludeAsync()
        {
            var services = await Db.Services.ToListAsync();

            foreach (var service in services)
            {
                service
                    .Manufacturers
                    .AddRange(
                        Db.Manufacturers
                            .Where(_ => Db
                            .ManufacturerServices
                            .Where(_ => _.ServiceFk == service.Id)
                            .Select(_ => _.ManufacturerFk)
                            .Contains(_.Id)));
            }
            return services;
        }
    }
}
