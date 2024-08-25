using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Termin
    {
        public int id { get; set; }

        public DateTime Datum { get; set; }

        public int Trajanje { get; set; }

        public int Cena { get; set; }
    }
}
