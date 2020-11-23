using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace UdemyNLayerProject.Core.Services
{
    public interface IService<TEntity> where TEntity :class
    {
        Task<TEntity> GetByIdAsync(int id);

        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// category.SingleOrDefaultAsync(x=>x.name="kalem")
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);

        Task AddAsync(TEntity entity);

        Task AddRangeAsync(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);

        void RemoveRange(IEnumerable<TEntity> entity);

        TEntity Update(TEntity entity);
    }
}
