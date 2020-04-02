using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge_14___miniprojekt
{
    public class Ingrediens
    {
        public String navn { get; }

        public int pris { get; }

        public Ingrediens(String paramName, int paramPris)
        {
            navn = paramName;
            pris = paramPris;
        }
    }
}
