using Domain;
using Domen;
using System.Data;

namespace SystemOperations.TerminSO
{
    public class SacuvajTerminSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            Termin termin = (Termin)entity;
            foreach (Termin t in Repository.GetAll(new Termin()))
            {
                if (t.TerminId == termin.TerminId)
                {
                    throw new DuplicateNameException($"Već postoji termin sa id-jem {t.TerminId}.");
                }
            }
            Repository.Save(termin);
        }
    }
}
