using System.Threading.Tasks;

namespace Core.Data.Operations
{
    public interface IOperableData
    {
        TEntity Add<TEntity>(TEntity entity) where TEntity : class;
        TEntity Update<TEntity>(TEntity entity) where TEntity : class;
        void Remove<TEntity>(TEntity entity) where TEntity : class;
        Task<TEntity> AddAsync<TEntity>(TEntity entity) where TEntity : class;
        Task<TEntity> UpdateAsync<TEntity>(TEntity entity) where TEntity : class;
        Task RemoveAsync<TEntity>(TEntity entity) where TEntity : class;
    }
}
