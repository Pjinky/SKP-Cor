using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge_14___miniprojekt
{
    class Order
    {
        public List<Pizza> pizzas { get; }
        public List<Drikkevare> drikkevarer { get; }
        public String pris { get; }
        public Order(List<Pizza> paramPizza, List<Drikkevare> paramDrikkevare)
        {
            pizzas = paramPizza;
            drikkevarer = paramDrikkevare;
        }
    }
}
