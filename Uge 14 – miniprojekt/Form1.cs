using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uge_14___miniprojekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listView1.Columns.Add("Navn");
            listView1.Columns.Add("Ingredienser");
            listView1.Columns.Add("Pris Normal/Familie");
            Helper helper = new Helper();
            List <Ingrediens> ingredients = helper.setIngredients(new string[] {"tomatsauce", "ost", "skinke", "ananas"} );
            Pizza pizzas = new Pizza("Hawaii", ingredients, Pizza.Size.FAMILIE, 125);
                        
        }
    }
}
