using Domain;
using Domen;
using System.Collections.Generic;
using System.Linq;

namespace SystemOperations.TerminSO
{
    public class PretragaTerminaSO : SystemOperationBase
    {
        public List<Termin> Result { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Result = Repository.GetSpecific(entity).Cast<Termin>().ToList();
        }
    }
}
