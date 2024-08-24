using Domain;
using Domen;

namespace SystemOperations.TrenerSO
{
    public class SacuvajClanaSO : SystemOperationBase
    {

        public Trener Result { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            // TODO [rpveri da li vec postoji osoba sa takvim ClientID-jem

            Clan clan = (Clan)entity;
            Repository.Save(clan);
        }
    }
}


