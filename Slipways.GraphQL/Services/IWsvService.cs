using System.Threading.Tasks;
using com.b_velop.Slipways.GraphQL.Data.Dtos;

namespace com.b_velop.Slipways.GraphQL.Services
{
    public interface IWsvService
    {
        Task<CurrentMeasurementResponse> GetAsync();
    }
}