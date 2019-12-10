using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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

        public async Task<ILookup<Guid, Service>> GetServicesByManufacturerIdAsync(
            IEnumerable<Guid> manufacturerIds,
            CancellationToken cancellationToken)
        {
            var services = await SelectAllAsync();
            var manufacturerServices = Db.ManufacturerServices.Where(_ => manufacturerIds.Contains(_.ManufacturerFk));
            var result = new List<Service>();

            foreach (var manufacturerService in manufacturerServices)
            {
                var service = services.FirstOrDefault(_ => _.Id == manufacturerService.ServiceFk);
                if (service != null)
                    result.Add(new Service
                    {
                        Id = service.Id,
                        Name = service.Name,
                        Street = service.Street,
                        Postalcode = service.Postalcode,
                        City = service.City,
                        Phone = service.Phone,
                        Url = service.Url,
                        Updated = service.Updated,
                        Longitude = service.Longitude,
                        Latitude = service.Latitude,
                        Email = service.Email,
                        Created = service.Created,
                        ManufacturerFk = manufacturerService.ManufacturerFk
                    });
            }
            return result.ToLookup(_ => _.ManufacturerFk);
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
