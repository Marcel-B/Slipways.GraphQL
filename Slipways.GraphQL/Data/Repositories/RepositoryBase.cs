using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using com.b_velop.Slipways.GraphQL.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

namespace com.b_velop.Slipways.GraphQL.Data.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class, IEntity
    {
        protected SlipwaysContext Db;
        private IMemoryCache _cache;
        private ILogger<RepositoryBase<T>> _logger;

        public RepositoryBase(
            SlipwaysContext db,
            IMemoryCache cache,
            ILogger<RepositoryBase<T>> logger)
        {
            Db = db;
            _cache = cache;
            _logger = logger;
        }

        public async Task<IEnumerable<T>> SelectAllAsync()
            => await Db.Set<T>().ToListAsync();

        public async Task<T> SelectByIdAsync(
            Guid id)
            => await Db.Set<T>().FirstOrDefaultAsync(_ => _.Id == id);

        public async Task<IEnumerable<T>> SelectByConditionAsync(Expression<Func<T, bool>> expression)
            => await Db.Set<T>().Where(expression).ToListAsync();

        public async Task<T> InsertAsync(
            T entity)
        {
            var result = await Db.Set<T>().AddAsync(entity);
            _ = Db.SaveChanges();
            return result.Entity;
        }

        public T Update(
            T entity)
        {
            var result = Db.Set<T>().Update(entity);
            _ = Db.SaveChanges();
            return result.Entity;
        }
    }
}
