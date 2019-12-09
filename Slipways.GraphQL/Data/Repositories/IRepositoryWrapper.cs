namespace com.b_velop.Slipways.GrQl.Data.Repositories
{
    public interface IRepositoryWrapper
    {
        IWaterRepository Water { get; }
        IStationRepository Station { get; }
        ISlipwayRepository Slipway { get; }
        IExtraRepository Extra { get; }
        IServiceRepository Service { get; }
        IManufacturerRepository Manufacturer { get; }
        IPortRepository Port { get; }
        ISlipwayExtraRepository SlipwayExtra { get; }
    }
}