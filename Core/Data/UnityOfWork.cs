using System;
using System.Data;

namespace Core.Data
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly IDataContext _dataContext;

        public UnityOfWork(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }


        public IDbTransaction BeginTransaction() =>
            _dataContext.BeginTransaction();

        public void Commit() =>
            _dataContext.Commit();

        public void Dispose() =>
            GC.SuppressFinalize(this);
    }
}
