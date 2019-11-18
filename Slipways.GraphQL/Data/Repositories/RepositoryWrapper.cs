using Microsoft.Extensions.Logging;

namespace com.b_velop.Slipways.GraphQL.Data.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly SlipwaysContext _db;
        private readonly ILogger<RepositoryWrapper> _logger;

        public IWaterRepository Water { get; set; }
        public IStationRepository Station { get; set; }

        public ISlipwayRepository Slipway { get; set; }

        public RepositoryWrapper(
            SlipwaysContext db,
            IWaterRepository waterRepository,
            IStationRepository stationRepository,
            ISlipwayRepository slipwayRepository,
            ILogger<RepositoryWrapper> logger)
        {
            _db = db;
            Water = waterRepository;
            Station = stationRepository;
            Slipway = slipwayRepository;
            _logger = logger;
        }
    }
}
