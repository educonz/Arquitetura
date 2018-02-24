using Core.Data.Operations;
using System;

namespace Core.Data
{
    public interface IUnityOfWork : ITransaction, IDisposable
    {
    }
}
