using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Webb4_DAL.IRepositories
{
    public interface IFormHousingDataModel<TEntity>
    {

        Task<TEntity> GetByIdAsync(Guid id);

        IQueryable<TEntity> SearchFor(Expression<Func<TEntity, bool>> predicate);

        IQueryable<TEntity> GetAll();

        Task EditAsync(TEntity entity);

        Task InsertAsync(TEntity entity);

        Task DeleteAsync(TEntity entity);
    }
}

