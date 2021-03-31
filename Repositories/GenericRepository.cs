using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.Interfaces;
using AppData;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly TheFirstSolutionEntities _dbContext;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(TheFirstSolutionEntities dbContext)
        {
            _dbContext = dbContext;
            _dbContext.Configuration.LazyLoadingEnabled = false;
            _dbContext.Configuration.AutoDetectChangesEnabled = false;
            _dbSet = _dbContext.Set<TEntity>();
        }


        public TEntity Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Delete(object id)
        {
            throw new NotImplementedException();
        }

        public TEntity Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.AsNoTracking();
        }

        public IEnumerable<TEntity> GetAll(params Expression<Func<TEntity, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> condition, params Expression<Func<TEntity, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetRandom(Expression<Func<TEntity, bool>> condition, int rows)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetRandom(Expression<Func<TEntity, bool>> condition, int rows, params Expression<Func<TEntity, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public TEntity GetSingle(Expression<Func<TEntity, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public TEntity GetSingle(Expression<Func<TEntity, bool>> condition, params Expression<Func<TEntity, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public TEntity GetSingleById(object id)
        {
            return _dbSet.Find(id);
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity, params Expression<Func<TEntity, object>>[] properties)
        {
            throw new NotImplementedException();
        }
    }
}
