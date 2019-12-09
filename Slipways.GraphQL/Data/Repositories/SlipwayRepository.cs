using com.b_velop.Slipways.GrQl.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace com.b_velop.Slipways.GrQl.Data.Repositories
{
    public class SlipwayRepository : RepositoryBase<Slipway>, ISlipwayRepository
    {
        private IExtraRepository _extraRepository;

        public SlipwayRepository(
            SlipwaysContext db,
            IExtraRepository extraRepository,
            ILogger<RepositoryBase<Slipway>> logger) : base(db, logger)
        {
            _extraRepository = extraRepository;
        }

        public async Task<ILookup<Guid, Slipway>> GetSlipwayByWaterIdAsync(
         IEnumerable<Guid> waterIds,
         CancellationToken cancellationToken)
        {
            var slipways = await SelectAllAsync();
            var result = new List<Slipway>();
            foreach (var slipway in slipways)
                if (waterIds.Contains(slipway.WaterFk))
                    result.Add(slipway);
            return result.ToLookup(x => x.WaterFk);
        }

        public async Task<ILookup<Guid, Slipway>> GetSlipwaysByExtraIdAsync(
             IEnumerable<Guid> extraIds,
             CancellationToken cancellationToken)
        {
            var slipways = await SelectAllAsync();
            var slipwayExtras = Db.SlipwayExtras.Where(_ => extraIds.Contains(_.ExtraFk));

            var result = new Dictionary<Guid, Slipway>();

            foreach (var slipwayExtra in slipwayExtras)
            {
                var slipway = slipways.First(_ => _.Id == slipwayExtra.SlipwayFk);
                result[slipwayExtra.ExtraFk] = slipway; 
            }
            return result.ToLookup(x => x.Key, x => x.Value);
        }

        public async Task<IEnumerable<Slipway>> SelectByExtraIdAsync(
            Guid extraId)
        {
            var extras = Db.SlipwayExtras.Where(_ => _.ExtraFk == extraId).Select(_ => _.SlipwayFk);
            var allSlips = await SelectIncludeAllAsync();
            return allSlips.Where(_ => extras.Contains(extraId));
        }

        public async Task<IEnumerable<Slipway>> SelectIncludeAllAsync()
        {
            var slipways = await Db
                  .Slipways
                  .Include(_ => _.Water)
                  .ToListAsync();

            foreach (var slipway in slipways)
            {
                slipway.Extras.AddRange(
                  (await _extraRepository.SelectAllAsync())
                      .Where(_ =>
                          Db.SlipwayExtras
                              .Where(_ => _.SlipwayFk == slipway.Id)
                              .Select(_ => _.ExtraFk)
                              .Contains(_.Id)));
            }
            return slipways;
        }

        public async Task<Slipway> SelectByIdIncludeAsync(
            Guid id)
        {
            var slipway = await Db.Slipways
              .Include(_ => _.Water)
              .FirstOrDefaultAsync(_ => _.Id == id);

            slipway.Extras.AddRange(
                (await _extraRepository.SelectAllAsync())
                    .Where(_ =>
                        Db.SlipwayExtras
                            .Where(_ => _.SlipwayFk == slipway.Id)
                            .Select(_ => _.ExtraFk)
                            .Contains(_.Id)));
            return slipway;
        }
    }
}
