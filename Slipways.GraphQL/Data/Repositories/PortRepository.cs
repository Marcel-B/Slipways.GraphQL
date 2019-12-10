using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using com.b_velop.Slipways.GrQl.Data.Models;
using Microsoft.Extensions.Logging;

namespace com.b_velop.Slipways.GrQl.Data.Repositories
{
    public interface IPortRepository : IRepositoryBase<Port>
    {
        Task<ILookup<Guid, Port>> GetPortsByWaterIdAsync(IEnumerable<Guid> waterIds, CancellationToken cancellationToken);
    }

    public class PortRepository : RepositoryBase<Port>, IPortRepository
    {
        private IWaterRepository _waterRepository;

        public PortRepository(
            SlipwaysContext db,
            IWaterRepository waterRepository,
            ILogger<RepositoryBase<Port>> logger) :
            base(db, logger)
        {
            _waterRepository = waterRepository;
        }


        public async Task<ILookup<Guid, Port>> GetPortsByWaterIdAsync(
            IEnumerable<Guid> waterIds,
            CancellationToken cancellationToken)
        {
            var ports = await SelectAllAsync();
            var waters = (await _waterRepository.SelectAllAsync()).Where(_ => waterIds.Contains(_.Id));

            var result = new List<Port>();

            foreach (var water in waters)
            {
                var port = ports.FirstOrDefault(_ => _.WaterFk == water.Id);
                if (port != null)
                    result.Add(port);
            }
            return result.ToLookup(_ => _.WaterFk);
        }
    }
}
