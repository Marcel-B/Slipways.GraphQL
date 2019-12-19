﻿using Microsoft.Extensions.Logging;

namespace com.b_velop.Slipways.GrQl.Data.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly SlipwaysContext _db;
        private readonly ILogger<RepositoryWrapper> _logger;

        public IWaterRepository Water { get; set; }
        public IStationRepository Station { get; set; }

        public ISlipwayRepository Slipway { get; set; }

        public IExtraRepository Extra { get; set; }

        public IServiceRepository Service { get; private set; }

        public IManufacturerRepository Manufacturer { get; private set; }

        public IPortRepository Port { get; private set; }
        public ISlipwayExtraRepository SlipwayExtra { get; }
        public IManufacturerServicesRepository ManufacturerServices { get; }

        public RepositoryWrapper(
            SlipwaysContext db,
            IWaterRepository waterRepository,
            IStationRepository stationRepository,
            ISlipwayRepository slipwayRepository,
            IExtraRepository extraRepository,
            IServiceRepository serviceRepository,
            IManufacturerRepository manufacturerRepository,
            IPortRepository portRepository,
            ISlipwayExtraRepository slipwayExtraRepository,
            IManufacturerServicesRepository manufacturerServicesRepository,
            ILogger<RepositoryWrapper> logger)
        {
            _db = db;
            Water = waterRepository;
            Station = stationRepository;
            Slipway = slipwayRepository;
            Extra = extraRepository;
            Service = serviceRepository;
            Manufacturer = manufacturerRepository;
            Port = portRepository;
            SlipwayExtra = slipwayExtraRepository;
            ManufacturerServices = manufacturerServicesRepository;
            _logger = logger;
        }
    }
}
