using Domain;
using Domen;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SystemOperations.TreningProgramSO
{
    public class VratiTreningProgrameSO : SystemOperationBase
    {
        public List<TreningProgram> Result { get; private set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Result = Repository.GetAll(new TreningProgram()).Cast<TreningProgram>().ToList();
        }
    }
}
