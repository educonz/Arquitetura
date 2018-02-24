namespace Core.Map
{
    public interface IMap
    {
        TOutput Map<TInput, TOutput>(TInput input);
    }
}
