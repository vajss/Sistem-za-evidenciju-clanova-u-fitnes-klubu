using Domen;
using Storage;
using Storage.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public abstract class SystemOperationBase
    {
        protected IGenericRepository Repository;

        public SystemOperationBase()
        {
            Repository = new GenericRepository();
        }

        public void ExecuteTemplate(IEntity entity)
        {
            try
            {
                Repository.OpenConnection();
                Repository.BeginTransaction();
                ExecuteOperation(entity);
                Repository.Commit();
            }
            catch (Exception)
            {
                Repository.Rollback();
                throw;
            }
            finally
            {
                Repository.CloseConnection();
            }
        }

        protected abstract void ExecuteOperation(IEntity entity);
    }
}
