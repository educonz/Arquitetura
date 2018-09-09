using Core.Data;
using Core.Data.Operations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Provider.EntityFramework
{
    public class EntityFrameworkContext : DbContext, IDataContext
    {
        private IDbContextTransaction _transaction;

        public virtual IDbTransaction BeginTransaction()
        {
            if (_transaction == null)
                _transaction = Database.BeginTransaction();

            return _transaction.GetDbTransaction();
        }

        public virtual void Commit()
        {
            SaveChanges();
            _transaction?.Commit();
            _transaction?.Dispose();
            _transaction = null;
        }

        TEntity IOperableData.Add<TEntity>(TEntity entity)
        {
            base.Add(entity);
            SaveChanges();
            return entity;
        }

        public virtual TEntity Find<TEntity, TPropertyType>(TPropertyType id)
            where TEntity : class
            where TPropertyType : struct =>
            Set<TEntity>().Find(id);

        IQueryable<TEntity> IReadeableData.Query<TEntity>() =>
            Set<TEntity>();

        public virtual IQueryable<TEntity> ReadOnlyQuery<TEntity>() where TEntity : class => Set<TEntity>().AsNoTracking();

        void IOperableData.Remove<TEntity>(TEntity entity)
        {
            base.Remove(entity);
            SaveChanges();
        }

        TEntity IOperableData.Update<TEntity>(TEntity entity)
        {
            base.Update(entity);
            SaveChanges();
            return entity;
        }

        public virtual Task<IQueryable<TEntity>> QueryAsync<TEntity>() where TEntity : class =>
            Task.FromResult<IQueryable<TEntity>>(Set<TEntity>());
        
        public virtual Task<IQueryable<TEntity>> ReadOnlyQueryAsync<TEntity>() where TEntity : class =>
            Task.FromResult(Set<TEntity>().AsNoTracking());

        public virtual async Task<TEntity> AddAsync<TEntity>(TEntity entity) where TEntity : class
        {
            await base.AddAsync(entity);
            await SaveChangesAsync();
            return entity;
        }

        public virtual async Task<TEntity> UpdateAsync<TEntity>(TEntity entity) where TEntity : class
        { 
            await Task.Run(() => base.Update(entity));
            await SaveChangesAsync();
            return entity;
        }

        public virtual async Task RemoveAsync<TEntity>(TEntity entity) where TEntity : class
        {
            await Task.Run(() => base.Remove(entity));
            await SaveChangesAsync();
        }
    }
}
