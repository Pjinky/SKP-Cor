using System;
using System.Collections;
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
        public List<Ingrediens> ingredienser { get; }

        public int getTotalPris()
        {
            int pris = 0;
            foreach (Ingrediens temp in ingredienser)
            {
                pris += temp.pris;
            }
            return pris;
        }

        public Pizza(String paramName, List<Ingrediens> paramIngredienser, Size paramSize) {
            ingredienser = paramIngredienser;
            navn = paramName;
            size = paramSize;
        }
    }

    public class Ingrediens
    {
        public String navn { get; }

        public int pris { get; }

        public Ingrediens(String paramName, int paramPris) {
            navn = paramName;
            pris = paramPris;
        }
    }
}
