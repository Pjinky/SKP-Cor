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

            listView1.Columns.Add("Navn", 100);
            listView1.Columns.Add("Ingredienser", 140);
            listView1.Columns.Add("Pris Normal/Familie", 100);
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, 40);
            listView1.SmallImageList = imgList;
            Helper helper = new Helper();
            List<Ingrediens> ingredients = helper.setIngredients(new string[] {"tomatsauce", "ost", "skinke", "ananas", "dressing"}, new int[] {5, 8, 5, 6, 8});
            List<Pizza> pizzas = new List<Pizza>();
            List<Order> orders = new List<Order>();
            List<Drikkevare> drikkevare = new List<Drikkevare>();
            pizzas.Add(new Pizza("Hawaii", ingredients, Pizza.Size.FAMILIE, Pizza.Dough.Hvidt, 5));
            pizzas.Add(new Pizza("Monster", ingredients, Pizza.Size.FAMILIE, Pizza.Dough.Hvidt));
            pizzas.Add(new Pizza("Kawaii", ingredients, Pizza.Size.FAMILIE, Pizza.Dough.Hvidt));
            pizzas.Add(new Pizza("Staun", ingredients, Pizza.Size.FAMILIE, Pizza.Dough.Groft));
            drikkevare.Add(new Drikkevare("Fanta", 45, Drikkevare.Size.MELLEM));
            orders.Add(new Order(pizzas, drikkevare));
            ListViewItem itm;
            string[] arr;
            foreach(Order order in orders)
            {
                foreach (Pizza pizza in order.pizzas)
                {
                    arr = new string[3];
                    arr[0] = pizza.navn;
                    foreach (Ingrediens temp in pizza.ingredienser)
                    {
                        arr[1] += temp.navn + ", ";
                    }
                    arr[2] = pizza.getTotalPris().ToString();
                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);
                }
            }
            
            listView1.View = View.Details;
        }
    }
}
