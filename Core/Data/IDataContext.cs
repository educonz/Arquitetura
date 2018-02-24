using Core.Data.Operations;
using System;

namespace Core.Data
{
    public interface IDataContext : ITransaction, IReadeableData, IOperableData, IDisposable
    {
    }
}
