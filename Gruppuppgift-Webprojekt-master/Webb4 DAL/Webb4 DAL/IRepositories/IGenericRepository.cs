﻿using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Webb4_DAL.IRepositories
{
    public interface IGenericRepository<TEntity>
    {

        Task<TEntity> GetByIdAsync(int id);

        IQueryable<TEntity> SearchFor(Expression<Func<TEntity, bool>> predicate);

        IQueryable<TEntity> GetAll();

        Task EditAsync(TEntity entity);

        Task InsertAsync(TEntity entity);

        Task DeleteAsync(TEntity entity);
    }
}
