using DataBaseBroker;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return broker.GetAll(entity);
        }

        // TODO not sure I need this
        /*public int GetNewId(IEntity e)
        {
            return broker.GetNewId(e);
        }*/

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

        public void Save(IEntity entity)
        {
            broker.Save(entity);
        }

        public void Update(IEntity entity)
        {
            broker.Update(entity);
        }
    }
}
