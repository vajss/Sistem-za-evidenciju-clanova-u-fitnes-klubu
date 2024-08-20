using Domen;
using System.Collections.Generic;

namespace Storage
{
    public interface IGenericRepository
    {
        void Save(IEntity entity);
        List<IEntity> GetAll(IEntity e);
        List<IEntity> GetSpecific(IEntity entity);
        void Update(IEntity entity);
        // int GetNewId(IEntity e); TODO not sure I need this
        void OpenConnection();
        void CloseConnection();
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
