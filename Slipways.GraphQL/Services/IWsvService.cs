using System.Threading.Tasks;
using com.b_velop.Slipways.GrQl.Data.Dtos;

namespace com.b_velop.Slipways.GrQl.Services
{
    public interface IWsvService
    {
        Task<CurrentMeasurementResponse> GetAsync();
    }
}