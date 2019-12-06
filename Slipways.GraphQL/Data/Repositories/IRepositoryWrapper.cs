namespace com.b_velop.Slipways.GrQl.Data.Repositories
{
    public interface IRepositoryWrapper
    {
        IWaterRepository Water { get; set; }
        IStationRepository Station { get; set; }
        ISlipwayRepository Slipway { get; set; }
        IExtraRepository Extra { get; }
        IServiceRepository Service { get; }
    }
}