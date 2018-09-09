using System;

namespace Core.Domain.ValidationsModel
{
    public interface IValidatorBuilder<TEntity>
        where TEntity : IEntityDomain, new()
    {
        IValidatorBuilder<TEntity> WithCondition(Func<TEntity, bool> condition);
        IValidatorBuilder<TEntity> ApplyMessage(string message);
        IResultValidation Verify(TEntity entity);
    }
}
