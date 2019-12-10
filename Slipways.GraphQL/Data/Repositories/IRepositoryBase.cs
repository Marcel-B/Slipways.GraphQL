using com.b_velop.Slipways.GrQl.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace com.b_velop.Slipways.GrQl.Data.Repositories
{
    public interface IRepositoryBase<T>
    {
        Task<T> InsertAsync(T entity);
        Task<int> InsertRangeAsync(IEnumerable<T> entity);
        Task<IEnumerable<T>> SelectAllAsync();
        Task<IEnumerable<T>> SelectByConditionAsync(Expression<Func<T, bool>> expression);
        Task<T> SelectByIdAsync(Guid id);
        T Update(T entity);
    }
}