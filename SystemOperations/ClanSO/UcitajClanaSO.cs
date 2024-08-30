using Domain;
using Domen;
using System.Linq;

namespace SystemOperations.ClanSO
{
    public class UcitajClanaSO : SystemOperationBase
    {
        public Clan Result { get; private set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Clan clan = (Clan)entity;
            clan.GCondition = $"C.Id = {clan.Id}";
            Result = Repository.GetSpecific(clan).Cast<Clan>().ToList()[0];
        }
    }
}