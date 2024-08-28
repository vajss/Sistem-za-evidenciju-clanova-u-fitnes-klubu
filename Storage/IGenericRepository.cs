using Domen;
using System.Collections.Generic;

namespace Storage
{
    public interface IGenericRepository
    {
        int Save(IEntity entity);
        List<IEntity> GetAll(IEntity e);
        List<IEntity> GetSpecific(IEntity entity);
        void Update(IEntity entity);
        void Delete(IEntity entity);
        void OpenConnection();
        void CloseConnection();
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
