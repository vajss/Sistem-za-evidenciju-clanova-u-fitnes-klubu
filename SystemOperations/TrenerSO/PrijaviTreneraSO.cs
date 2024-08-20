using Domain;
using Domen;


namespace SystemOperations.TrenerSO
{
    public class PrijaviTreneraSO : SystemOperationBase
    {
        public Trener Result { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Trener trener = (Trener)entity;
            foreach (Trener t in Repository.GetAll(new Trener()))
            {
                if (t.KorisnickoIme == trener.KorisnickoIme &&
                    t.Sifra == trener.Sifra)
                {
                    trener.Ime = t.Ime;
                    trener.Id = t.Id;

                    Result = trener;
                }
            }
        }
    }
}
