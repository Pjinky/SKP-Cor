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
        public List<Ingrediens> setIngredients(String[] name)
        {
            List<Ingrediens> ingredients = new List<Ingrediens>();
            foreach(String temp in name)
            {
                Ingrediens ingredient = new Ingrediens(temp);
                ingredients.Add(ingredient);
            };
            return ingredients;
        }
    }
}
