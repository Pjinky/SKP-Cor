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

        public int getTotalPris()
        {
            int pris = 0;
            foreach(Pizza temp in pizzas)
            {
                pris += temp.pris;
            };
            return pris;
        }
    }
}
