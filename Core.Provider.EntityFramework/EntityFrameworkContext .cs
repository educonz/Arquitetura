using Core.Data;
using Core.Data.Operations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
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
            return entity;
        }

        public virtual TEntity Find<TEntity, TPropertyType>(TPropertyType id)
            where TEntity : class
            where TPropertyType : struct =>
            Set<TEntity>().Find(id);

        public virtual IQueryable<TEntity> Query<TEntity>() where TEntity : class =>
            Set<TEntity>();

        public virtual IQueryable<TEntity> ReadOnlyQuery<TEntity>() where TEntity : class => Set<TEntity>().AsNoTracking();

        void IOperableData.Remove<TEntity>(TEntity entity) => base.Remove(entity);

        TEntity IOperableData.Update<TEntity>(TEntity entity)
        {
            base.Update(entity);
            return entity;
        }

        public virtual async Task<IQueryable<TEntity>> QueryAsync<TEntity>() where TEntity : class
        {
            var list = await Set<TEntity>().ToListAsync();
            return list.AsQueryable();
        }
        

        public virtual async Task<IQueryable<TEntity>> ReadOnlyQueryAsync<TEntity>() where TEntity : class
        {
            var list = await Set<TEntity>().AsNoTracking().ToListAsync();
            return list.AsQueryable();
        }

        public virtual async Task<TEntity> AddAsync<TEntity>(TEntity entity) where TEntity : class
        {
            await base.AddAsync(entity);
            return entity;
        }

        public virtual async Task<TEntity> UpdateAsync<TEntity>(TEntity entity) where TEntity : class
        { 
            await Task.Run(() => base.Update(entity));
            return entity;
        }

        public virtual async Task RemoveAsync<TEntity>(TEntity entity) where TEntity : class
        {
            await Task.Run(() => base.Remove(entity));
        }
    }
}
