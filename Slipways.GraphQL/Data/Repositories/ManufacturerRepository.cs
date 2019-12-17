using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using com.b_velop.Slipways.GrQl.Data.Models;
using com.b_velop.Slipways.GrQl.Infrastructure;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

namespace com.b_velop.Slipways.GrQl.Data.Repositories
{
    public class ManufacturerRepository : CachedRepositoryBase<Manufacturer>, IManufacturerRepository
    {
        public ManufacturerRepository(
            SlipwaysContext db,
            IMemoryCache cache,
            ILogger<RepositoryBase<Manufacturer>> logger) : base(db, cache, logger)
        {
            Key = Cache.Manufacturer;
        }

        public async Task<ILookup<Guid, Manufacturer>> GetManufacturerByServiceIdAsync(
            IEnumerable<Guid> serviceIds,
            CancellationToken cancellationToken)
        {
            var manufacturers = await SelectAllAsync();
            var manufacturerServices = Db.ManufacturerServices.Where(_ => serviceIds.Contains(_.ServiceFk));
            var result = new List<Manufacturer>();

            foreach (var manufacturerService in manufacturerServices)
            {
                var manufacturer = manufacturers.FirstOrDefault(_ => _.Id == manufacturerService.ManufacturerFk);
                if (manufacturer != null)
                    result.Add(new Manufacturer
                    {
                        Id = manufacturer.Id,
                        Name = manufacturer.Name,
                        Updated = manufacturer.Updated,
                        Created = manufacturer.Created,
                        ServiceFk = manufacturerService.ServiceFk
                    });
            }
            return result.ToLookup(_ => _.ServiceFk);
        }

        public override async Task<IEnumerable<Manufacturer>> SelectAllAsync()
        {
            if (!_cache.TryGetValue(Cache.Manufacturer, out IEnumerable<Manufacturer> manufacturers))
            {
                manufacturers = await base.SelectAllAsync();
                _cache.Set(Cache.Manufacturer, manufacturers);
            }
            return manufacturers;
        }
    }
}
