using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using com.b_velop.Slipways.GraphQL.Data.Models;

namespace com.b_velop.Slipways.GraphQL.Data.Repositories
{
    public interface IRepositoryBase<T> where T : class, IEntity
    {
        Task<T> InsertAsync(T entity);
        Task<IEnumerable<T>> SelectAllAsync();
        Task<IEnumerable<T>> SelectByConditionAsync(Expression<Func<T, bool>> expression);
        Task<T> SelectByIdAsync(Guid id);
        T Update(T entity);
    }
}