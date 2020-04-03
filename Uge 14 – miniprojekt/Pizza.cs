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
        public int rabat { get; }
        public enum Dough
        {
            Hvidt,
            Saltet,
            Groft
        }

        Dough dough { get; }

        public int getTotalPris()
        {
            int pris = 0;
            foreach (Ingrediens temp in ingredienser)
            {
                pris += temp.pris;
            }
            if(rabat > 0)
            {
                pris = pris - (rabat * pris / 100);
            }
            return pris;
        }

        public Pizza(String paramName, List<Ingrediens> paramIngredienser, Size paramSize, Dough paramDough, int paramDiscount = 0) {
            ingredienser = paramIngredienser;
            navn = paramName;
            size = paramSize;
            rabat = paramDiscount;
            dough = paramDough;
        }
    }
}
