﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Webb4_DAL.IRepositories;
using Webb4_DAL.Models;

namespace Webb4_DAL.Repositories
{
    public class AreaDataModelIRepository<TEntity> : IAreaDataModel<TEntity> where TEntity : class
    {
        protected DbSet<TEntity> DbSet;

        private readonly DbContext _dbContext;

        public AreaDataModelIRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            DbSet = _dbContext.Set<TEntity>();
        }

        public AreaDataModelIRepository()
        {
        }

        public IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public IQueryable<TEntity> SearchFor(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public async Task EditAsync(TEntity entity)
        {
            //_dbContext.Entry(entity).State = EntityState.Modified;
            var entry = _dbContext.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                _dbContext.Set<TEntity>().Attach(entity);
                entry.State = EntityState.Modified;
            }


            await _dbContext.SaveChangesAsync();
        }

        public async Task InsertAsync(TEntity entity)
        {

            DbSet.Add(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(TEntity entity)
        {
            DbSet.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
