﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;


namespace Repositories.Interfaces
{
    public interface IGenericRepository<TEntity>
    {
        TEntity Add(TEntity entity);

        TEntity Delete(object id);

        TEntity Delete(TEntity entity);

        void Update(TEntity entity);

        void Update(TEntity entity, params Expression<Func<TEntity, object>>[] properties);

        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> GetAll(params Expression<Func<TEntity, object>>[] includes);

        IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> condition);

        IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> condition, params Expression<Func<TEntity, object>>[] includes);

        IEnumerable<TEntity> GetRandom(Expression<Func<TEntity, bool>> condition, int rows);

        IEnumerable<TEntity> GetRandom(Expression<Func<TEntity, bool>> condition, int rows, params Expression<Func<TEntity, object>>[] includes);

        TEntity GetSingleById(object id);

        TEntity GetSingle(Expression<Func<TEntity, bool>> condition);

        TEntity GetSingle(Expression<Func<TEntity, bool>> condition, params Expression<Func<TEntity, object>>[] includes);
    }
}
