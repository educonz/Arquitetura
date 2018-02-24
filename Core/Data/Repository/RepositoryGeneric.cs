using System.Linq;
using System.Threading.Tasks;

namespace Core.Data.Repository
{
    public class RepositoryGeneric : IRepositoryGeneric
    {
        private readonly IDataContext _dataContext;

        public RepositoryGeneric(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public TEntity Add<TEntity>(TEntity entity) where TEntity : class =>
            _dataContext.Add(entity);

        public async Task<TEntity> AddAsync<TEntity>(TEntity entity) where TEntity : class =>
            await _dataContext.AddAsync(entity);

        public IQueryable<TEntity> Query<TEntity>() where TEntity : class =>
            _dataContext.Query<TEntity>();

        public async Task<IQueryable<TEntity>> QueryAsync<TEntity>() where TEntity : class =>
            await _dataContext.QueryAsync<TEntity>();

        public IQueryable<TEntity> ReadOnlyQuery<TEntity>() where TEntity : class =>
            _dataContext.ReadOnlyQuery<TEntity>();

        public async Task<IQueryable<TEntity>> ReadOnlyQueryAsync<TEntity>() where TEntity : class =>
            await _dataContext.ReadOnlyQueryAsync<TEntity>();

        public void Remove<TEntity>(TEntity entity) where TEntity : class =>
            _dataContext.Remove(entity);

        public async Task RemoveAsync<TEntity>(TEntity entity) where TEntity : class =>
            await _dataContext.RemoveAsync(entity);

        public TEntity Update<TEntity>(TEntity entity) where TEntity : class =>
            _dataContext.Update(entity);

        public async Task<TEntity> UpdateAsync<TEntity>(TEntity entity) where TEntity : class =>
            await _dataContext.UpdateAsync(entity);
        
    }
}
