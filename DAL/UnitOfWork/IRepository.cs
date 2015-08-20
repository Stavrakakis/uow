﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DAL.UnitOfWork
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Insert(TEntity entity);

        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
    }
}
