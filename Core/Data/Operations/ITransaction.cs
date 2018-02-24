using System;
using System.Data;

namespace Core.Data.Operations
{
    public interface ITransaction : IDisposable
    {
        IDbTransaction BeginTransaction();
        void Commit();
    }
}
