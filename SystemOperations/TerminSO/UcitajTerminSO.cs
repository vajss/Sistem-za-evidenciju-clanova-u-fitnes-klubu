using Domain;
using Domen;
using System.Linq;

namespace SystemOperations.TerminSO
{
    public class UcitajTerminSO : SystemOperationBase
    {
        public Termin Result { get; private set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Termin termin = (Termin)entity;
            termin.GCondition = $"TE.Id = {termin.Id}";
            Result = Repository.GetSpecific(termin).Cast<Termin>().ToList()[0];
        }
    }
}
