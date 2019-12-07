using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using com.b_velop.Slipways.GrQl.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace com.b_velop.Slipways.GrQl.Data.Repositories
{
    public class ServiceRepository : RepositoryBase<Service>, IServiceRepository
    {
        private IManufacturerRepository _rep;

        public ServiceRepository(
            SlipwaysContext db,
            IManufacturerRepository rep,
            ILogger<RepositoryBase<Service>> logger) : base(db, logger)
        {
            _rep = rep;
        }

        public async Task<IEnumerable<Service>> GetAllIncludeAsync()
        {
            var services = await Db.Services.ToListAsync();

            foreach (var service in services)
            {
                service
                    .Manufacturers
                    .AddRange(
                        (await _rep.SelectAllAsync())
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
