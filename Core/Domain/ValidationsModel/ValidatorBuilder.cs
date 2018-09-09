using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Domain.ValidationsModel
{
    public class ValidatorBuilder<TEntity> : IValidatorBuilder<TEntity>
        where TEntity : IEntityDomain, new()
    {
        private readonly IList<Func<TEntity, bool>> _functions = new List<Func<TEntity, bool>>();
        private string _message = string.Empty;

        public IValidatorBuilder<TEntity> ApplyMessage(string message)
        {
            _message = message;
            return this;
        }

        public IValidatorBuilder<TEntity> WithCondition(Func<TEntity, bool> condition)
        {
            _functions.Add(condition);
            return this;
        }

        public IResultValidation Verify(TEntity entity)
        {
            var anyConditionIsTruth = _functions
                .Select(x => x.Invoke(entity))
                .Any(condicaoResultado => condicaoResultado);

            return anyConditionIsTruth
                ? ResultValidation.CreateError(_message)
                : ResultValidation.CreateSuccess("Condition is valid.");
        }
    }
}
