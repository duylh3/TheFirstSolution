using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.Interfaces;
using AppData;

namespace Repositories
{
   public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public IGenericRepository<UserInfo> UserInfoRepository { get; private set; }

        private readonly TheFirstSolutionEntities _dbContext;
        private bool _disposed;

        public UnitOfWork(TheFirstSolutionEntities dbContext)
        { 
            _dbContext = dbContext;
            UserInfoRepository = new GenericRepository<UserInfo>(_dbContext);
        }


        public void Commit(bool? validateOnSaveEnabled = null)
        {
            if (validateOnSaveEnabled != null)
            {
                _dbContext.Configuration.ValidateOnSaveEnabled = (bool)validateOnSaveEnabled;
            }
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            _disposed = true;
        }

        ~UnitOfWork()
        {
            Dispose();
        }
    }
}
