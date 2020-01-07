using com.b_velop.Slipways.Data.Contracts;
using System.Threading.Tasks;

namespace com.b_velop.Slipways.GrQl.Contracts
{
    public interface IInitializer
    {
        Task InitDatabase<T>(string path, string name) where T : class, IEntity;
        Task InitCache<T>(string name) where T : class, IEntity;
    }
}