using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge_14___miniprojekt
{
    class Helper
    {
        public List<Ingrediens> setIngredients(String[] name, int[] pris)
        {
            List<Ingrediens> ingredients = new List<Ingrediens>();
            int count = 0;
            foreach(String temp in name)
            {
                Ingrediens ingredient = new Ingrediens(temp, pris[count]);
                ingredients.Add(ingredient);
                count++;
            };
            return ingredients;
        }

        
    }
}
