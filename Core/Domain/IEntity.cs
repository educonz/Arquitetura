namespace Core.Domain
{
    public interface IEntity<TKey> : IEntityDomain
        where TKey : struct
    {
        TKey Id { get; set; }
    }
}
