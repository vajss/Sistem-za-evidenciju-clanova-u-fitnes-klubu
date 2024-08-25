using Domain;
using Domen;
using System.Collections.Generic;
using System.Linq;

namespace SystemOperations.ClanSO
{
    public class PretragaClanovaSO : SystemOperationBase
    {
        public List<Clan> Result { get; private set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Result = Repository.GetSpecific(entity).Cast<Clan>().ToList();
        }
    }
}
