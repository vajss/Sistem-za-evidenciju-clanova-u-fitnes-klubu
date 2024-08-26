using Domain;
using Domen;

namespace SystemOperations.TerminSO
{
    public class SacuvajTerminSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            Termin termin = (Termin)entity;
            Repository.Save(termin);
        }
    }
}
