using Domain;
using Domen;
using System.Linq;

namespace SystemOperations.GrupaSO
{
    public class UcitajGrupuSO : SystemOperationBase
    {
        public Grupa Result { get; private set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Grupa grupa = (Grupa)entity;
            grupa.GCondition = $"G.Id = {grupa.Id}";

            Clanstvo clanstvo = new Clanstvo
            {
                GCondition = $"CL.GrupaId = {grupa.Id}"
            };

            Grupa g = Repository.GetSpecific(grupa).Cast<Grupa>().ToList()[0];
            g.Clanstva = Repository.GetSpecific(clanstvo).Cast<Clanstvo>().ToList();
            Result = g;
        }
    }
}