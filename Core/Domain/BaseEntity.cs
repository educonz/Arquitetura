namespace Core.Domain
{
    public abstract class BaseEntity<TKey> : IEntity<TKey>
        where TKey : struct
    {
        public virtual TKey Id { get; set; }
    }
}
