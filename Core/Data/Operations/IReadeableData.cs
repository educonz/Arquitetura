using System.Linq;
using System.Threading.Tasks;

namespace Core.Data.Operations
{
    public interface IReadeableData
    {
        IQueryable<TEntity> Query<TEntity>() where TEntity : class;
        IQueryable<TEntity> ReadOnlyQuery<TEntity>() where TEntity : class;
        Task<IQueryable<TEntity>> QueryAsync<TEntity>() where TEntity : class;
        Task<IQueryable<TEntity>> ReadOnlyQueryAsync<TEntity>() where TEntity : class;
    }
}
