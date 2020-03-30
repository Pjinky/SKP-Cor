using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge_14___miniprojekt
{
    public class Pizza
    {
        public enum Size
        {
            NORMAL,
            FAMILIE
        }

        public String navn { get; }
        public Size size { get; }
        public int pris { get; }
        List<Ingrediens> ingrediens { get; }

        public Pizza(String paramName, List<Ingrediens> paramIngredienser, Size paramSize, int paramPris) { }

    }

    public class Ingrediens
    {
        public String navn { get; }

        public Ingrediens(String paramName) { }
    }
}
