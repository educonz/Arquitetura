using System.Linq;
using System.Threading.Tasks;

namespace Core.Data.Repository
{
    public interface IRepository<TEntity>
        where TEntity : class, new()
    {
        TEntity Add(TEntity entity);
        TEntity Update(TEntity entity);
        void Remove(TEntity entity);
        IQueryable<TEntity> Query();
        IQueryable<TEntity> ReadOnlyQuery();
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task RemoveAsync(TEntity entity);
        Task<IQueryable<TEntity>> QueryAsync();
        Task<IQueryable<TEntity>> ReadOnlyQueryAsync();
    }
}
