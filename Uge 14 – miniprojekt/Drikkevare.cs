using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge_14___miniprojekt
{
    class Drikkevare
    {
        public String navn;
        public int pris;
        public enum Size
        {
            LILLE,
            MELLEM,
            STOR
        }
        public Size size { get; }

        public Drikkevare(String paramNavn, int paramPris, Size paramSize)
        {
            size = paramSize;
            navn = paramNavn;
            pris = paramPris;
        }
    }
}
