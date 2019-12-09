using com.b_velop.Slipways.GrQl.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
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
