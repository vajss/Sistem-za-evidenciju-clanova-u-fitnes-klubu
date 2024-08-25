using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Grupa
    {
        public int Id { get; set; }

        public int BrojClanova { get; set; }

        public string Naziv { get; set; }
    }
}
