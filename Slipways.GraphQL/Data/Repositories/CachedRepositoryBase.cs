using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using com.b_velop.Slipways.GrQl.Data.Models;
using com.b_velop.Slipways.GrQl.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

namespace com.b_velop.Slipways.GrQl.Data.Repositories
{

    public interface ICachedRepositoryBase<T> : IRepositoryBase<T>
    {
    }

    public class CachedRepositoryBase<T> : RepositoryBase<T>, ICachedRepositoryBase<T> where T : class, IEntity, new()
    {
        protected IMemoryCache _cache;

        public CachedRepositoryBase(
            SlipwaysContext db,
            IMemoryCache cache,
            ILogger<RepositoryBase<T>> logger) : base(db, logger)
        {
            _cache = cache;
        }
    }
}
