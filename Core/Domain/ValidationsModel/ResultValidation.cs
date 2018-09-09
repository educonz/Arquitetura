namespace Core.Domain.ValidationsModel
{
    public class ResultValidation : IResultValidation
    {
        public ResultValidation(string message)
            : this(message, false)
        {
        }

        public ResultValidation(string message, bool isValid)
        {
            IsValid = isValid;
            Message = message;
        }

        public bool IsValid { get; private set; }

        public string Message { get; private set; }

        public static IResultValidation CreateError(string message)
        {
            return new ResultValidation(message, false);
        }

        public static IResultValidation CreateSuccess(string message)
        {
            return new ResultValidation(message, true);
        }
    }
}
