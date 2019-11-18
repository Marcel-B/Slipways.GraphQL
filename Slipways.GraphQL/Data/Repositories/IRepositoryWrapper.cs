namespace com.b_velop.Slipways.GraphQL.Data.Repositories
{
    public interface IRepositoryWrapper
    {
        IWaterRepository Water { get; set; }
        IStationRepository Station { get; set; }
        ISlipwayRepository Slipway { get; set; }
    }
}