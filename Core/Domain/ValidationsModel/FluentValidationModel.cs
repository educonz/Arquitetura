using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Domain.ValidationsModel
{
    public abstract class FluentValidationModel<TEntity> : IFluentValidationModel<TEntity>
        where TEntity : IEntityDomain, new()
    {
        private IList<Func<TEntity, IResultValidation>> _validations = new List<Func<TEntity, IResultValidation>>();

        protected IValidatorBuilder<TEntity> Validation()
        {
            var validator = new ValidatorBuilder<TEntity>();
            _validations.Add((entity) => validator.Verify(entity));
            return validator;
        }

        public IEnumerable<IResultValidation> Validate(TEntity entity) =>
            _validations
                .Select(x => x.Invoke(entity))
                .Where(x => !x.IsValid);
    }
}
