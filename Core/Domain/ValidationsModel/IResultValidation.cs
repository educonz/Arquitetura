namespace Core.Domain.ValidationsModel
{
    public interface IResultValidation
    {
        bool IsValid { get; }
        string Message { get; }
    }
}
