using System.Collections.Generic;

namespace Core.User
{
    public interface IKeyValueRole<TKey, TValue> : IRole
    {
        IDictionary<TKey, TValue> Roles { get; set; }
    }
}
