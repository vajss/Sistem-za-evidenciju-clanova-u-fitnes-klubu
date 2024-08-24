using Domain;
using Domen;
using System.Data;
using System.Diagnostics;

namespace SystemOperations.ClanSO
{
    public class SacuvajClanaSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            Clan clan = (Clan)entity;
            Debug.WriteLine("####################### POVO????");
            foreach (Clan c in Repository.GetAll(new Clan()))
            {
                if (c.ClanId == clan.ClanId)
                {
                    throw new DuplicateNameException("ClientId mora biti jedinstvern.");
                }
            }

            Repository.Save(clan);
        }
    }
}


