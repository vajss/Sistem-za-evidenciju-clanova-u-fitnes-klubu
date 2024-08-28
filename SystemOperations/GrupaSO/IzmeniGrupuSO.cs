using Domain;
using Domen;
using System.Collections.Generic;
using System.Linq;

namespace SystemOperations.GrupaSO
{
    public class IzmeniGrupuSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            Grupa grupa = (Grupa)entity;

            Repository.Update(grupa);

            Clanstvo clanstvo = new Clanstvo
            {
                Grupa = grupa,
            };
            clanstvo.GCondition = $"CL.GrupaId = {grupa.Id}";
            List<Clanstvo> clanstvaGrupeUBazi = Repository.GetSpecific(clanstvo).Cast<Clanstvo>().ToList();

            foreach (Clanstvo existing in clanstvaGrupeUBazi) 
            {
                if (!grupa.Clanstva.Contains(existing))
                {
                    Repository.Delete(existing);
                }
            }

           foreach (Clanstvo cl in grupa.Clanstva)
            {
                cl.Grupa = grupa;
                if (clanstvaGrupeUBazi.Contains(cl))
                {
                    Repository.Update(cl);
                }
                else
                {
                    Repository.Save(cl);
                }
            }
        }
    }
}
