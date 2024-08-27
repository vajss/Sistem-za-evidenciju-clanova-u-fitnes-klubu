using Domain;
using Domen;
using System.Collections.Generic;
using System.Linq;

namespace SystemOperations.GrupaSO
{
    public class VratiSveGrupeSO : SystemOperationBase
    {
        public List<Grupa> Result { get; private set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Result = Repository.GetAll(new Grupa()).Cast<Grupa>().ToList();

            Result.ForEach((Grupa grupa) => {
                Clanstvo clanstvo = new Clanstvo { 
                     Grupa = grupa,
                };

                clanstvo.GCondition = $"CL.GrupaId = {grupa.Id}";
                List<Clanstvo> clanstva = Repository.GetSpecific(clanstvo).Cast<Clanstvo>().ToList();
                grupa.Clanstva = clanstva;
            });
        }
    }
}
