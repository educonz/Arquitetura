using System.Linq;
using System.Threading.Tasks;

namespace Core.Data.Repository
{
    public abstract class RepositorySpecialized<TEntity> : IRepositorySpecialized<TEntity>
        where TEntity : class, new()
    {
        protected readonly IRepository Repository;

        public RepositorySpecialized(IRepository repositoryGeneric)
        {
            Repository = repositoryGeneric;
        }

        public virtual TEntity Add(TEntity entity) =>
           Repository.Add(entity);

        public virtual async Task<TEntity> AddAsync(TEntity entity) =>
            await Repository.AddAsync(entity);

        public virtual IQueryable<TEntity> Query() =>
            Repository.Query<TEntity>();

        public virtual async Task<IQueryable<TEntity>> QueryAsync() =>
            await Repository.QueryAsync<TEntity>();

        public virtual IQueryable<TEntity> ReadOnlyQuery() =>
            Repository.ReadOnlyQuery<TEntity>();

        public virtual async Task<IQueryable<TEntity>> ReadOnlyQueryAsync() =>
            await Repository.ReadOnlyQueryAsync<TEntity>();

        public virtual void Remove(TEntity entity) =>
            Repository.Remove(entity);

        public virtual async Task RemoveAsync(TEntity entity) =>
            await Repository.RemoveAsync(entity);

        public virtual TEntity Update(TEntity entity) =>
            Repository.Update(entity);

        public virtual async Task<TEntity> UpdateAsync(TEntity entity) =>
            await Repository.UpdateAsync(entity);
    }
}
