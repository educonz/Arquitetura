using System.Collections.Generic;

namespace Core.Domain.ValidationsModel
{
    public interface IFluentValidationModel<TEntity>
        where TEntity : IEntityDomain, new()
    {
        IEnumerable<IResultValidation> Validate(TEntity entity);
    }
}
