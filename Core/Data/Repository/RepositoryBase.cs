using System.Linq;
using System.Threading.Tasks;

namespace Core.Data.Repository
{
    public abstract class RepositoryBase<TEntity> : IRepository<TEntity>
        where TEntity : class, new()
    {
        protected readonly IDataContext DataContext;

        public RepositoryBase(IDataContext dataContext)
        {
            DataContext = dataContext;
        }

        public virtual TEntity Add(TEntity entity) =>
           DataContext.Add(entity);

        public virtual async Task<TEntity> AddAsync(TEntity entity) =>
            await DataContext.AddAsync(entity);

        public virtual IQueryable<TEntity> Query() =>
            DataContext.Query<TEntity>();

        public virtual async Task<IQueryable<TEntity>> QueryAsync() =>
            await DataContext.QueryAsync<TEntity>();

        public virtual IQueryable<TEntity> ReadOnlyQuery() =>
            DataContext.ReadOnlyQuery<TEntity>();

        public virtual async Task<IQueryable<TEntity>> ReadOnlyQueryAsync() =>
            await DataContext.ReadOnlyQueryAsync<TEntity>();

        public virtual void Remove(TEntity entity) =>
            DataContext.Remove(entity);

        public virtual async Task RemoveAsync(TEntity entity) =>
            await DataContext.RemoveAsync(entity);

        public virtual TEntity Update(TEntity entity) =>
            DataContext.Update(entity);

        public virtual async Task<TEntity> UpdateAsync(TEntity entity) =>
            await DataContext.UpdateAsync(entity);
    }
}
