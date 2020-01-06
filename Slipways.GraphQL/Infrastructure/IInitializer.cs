using System.Threading.Tasks;
using com.b_velop.Slipways.Data.Contracts;

namespace com.b_velop.Slipways.GrQl.Infrastructure
{
    public interface IInitializer
    {
        Task InitDatabase<T>(string path, string name) where T : class, IEntity;
        Task InitCache<T>(string name) where T : class, IEntity;
    }
}