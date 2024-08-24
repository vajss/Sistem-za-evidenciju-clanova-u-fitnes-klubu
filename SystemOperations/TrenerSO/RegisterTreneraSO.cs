using Domain;
using Domen;
using System.Data;


namespace SystemOperations.TrenerSO
{
    public class RegisterTreneraSO : SystemOperationBase
    {

        public Trener Result { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Trener trener = (Trener)entity;
            foreach (Trener t in Repository.GetAll(new Trener()))
            {
                if (t.KorisnickoIme == trener.KorisnickoIme)
                {
                    throw new DuplicateNameException("Korisnicko ime je zauzeto.");
                }
            }
            Repository.Save(trener);
        }
    }
}


