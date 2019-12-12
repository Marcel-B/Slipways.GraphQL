using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using com.b_velop.Slipways.GrQl.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace com.b_velop.Slipways.GrQl.Data.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class, IEntity
    {
        protected SlipwaysContext Db;
        protected ILogger<RepositoryBase<T>> _logger;

        public RepositoryBase(
            SlipwaysContext db,
            ILogger<RepositoryBase<T>> logger)
        {
            Db = db;
            _logger = logger;
        }

        public virtual async Task<IEnumerable<T>> SelectAllAsync()
            => await Db.Set<T>().ToListAsync();

        public virtual async Task<T> SelectByIdAsync(
            Guid id)
            => await Db.Set<T>().FirstOrDefaultAsync(_ => _.Id == id);

        public virtual async Task<IEnumerable<T>> SelectByConditionAsync(Expression<Func<T, bool>> expression)
            => await Db.Set<T>().Where(expression).ToListAsync();

        public virtual async Task<T> InsertAsync(
            T entity)
        {
            entity.Created = DateTime.Now;
            var result = await Db.Set<T>().AddAsync(entity);
            _ = Db.SaveChanges();
            return result.Entity;
        }

        public virtual async Task<int> InsertRangeAsync(
            IEnumerable<T> entity)
        {
            await Db.Set<T>().AddRangeAsync(entity);
            var count = Db.SaveChanges();
            return count;
        }

        public virtual T Update(
            T entity)
        {
            entity.Updated = DateTime.Now;
            var result = Db.Set<T>().Update(entity);
            _ = Db.SaveChanges();
            return result.Entity;
        }

        public virtual async Task<T> DeleteAsync(
            Guid id)
        {
            var tmp = await Db.Set<T>().FirstOrDefaultAsync(_ => _.Id == id);
            if (tmp == null)
            {
                _logger.LogWarning(5555, $"Can't delete Entity with ID '{id}'. Entity not exsists");
                return null;
            }
            var result = Db.Set<T>().Remove(tmp);
            _ = Db.SaveChanges();
            return result.Entity;
        }
    }
}
