using DataBaseBroker;
using Domen;
using System.Collections.Generic;
using System.Diagnostics;

namespace Storage.Implementation
{
    public class GenericRepository : IGenericRepository
    {
        private DBBroker broker = new DBBroker();
        public void BeginTransaction()
        {
            broker.BeginTransaction();
        }

        public void CloseConnection()
        {
            broker.CloseConnection();
        }

        public void Commit()
        {
            broker.Commit();
        }

        public List<IEntity> GetAll(IEntity entity)
        {
            Debug.WriteLine(">>>>>> get all");
            return broker.GetAll(entity);
        }

        public List<IEntity> GetSpecific(IEntity entity)
        {
            return broker.GetSpecific(entity);
        }

        public void OpenConnection()
        {
            broker.OpenConnection();
        }

        public void Rollback()
        {
            broker.Rollback();
        }

        public int Save(IEntity entity)
        {
            return broker.Save(entity);
        }

        public void Delete(IEntity entity)
        {
            broker.Delete(entity);
        }

        public void Update(IEntity entity)
        {
            broker.Update(entity);
        }
    }
}
