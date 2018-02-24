namespace Core.User
{
    public interface IUserRole<TKey, TValue> : IKeyValueRole<TKey, TValue>, IUser
    {
    }
}
