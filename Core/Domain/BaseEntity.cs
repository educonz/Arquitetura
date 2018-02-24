namespace Core.Domain
{
    public abstract class BaseEntity : IEntity
    {
        public virtual long Id { get; set; }
    }
}
