using Domain;
using Domen;

namespace SystemOperations.ClanSO
{
    public class IzmeniClanaSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            Clan clan = (Clan)entity;
            Repository.Update(clan);
        }
    }
}
