using Domain;
using Domen;

namespace SystemOperations.GrupaSO
{
    public class SacuvajGrupuSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            Grupa grupa = (Grupa)entity;
            int groupId = Repository.Save(grupa);

            foreach (Clanstvo c in grupa.Clanstva)
            {
                c.Grupa = new Grupa
                {
                    Id = groupId
                };
                Repository.Save(c);
            }
            
        }

    }
}
