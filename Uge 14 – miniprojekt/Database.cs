using MySql.Data.MySqlClient;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uge_14___miniprojekt
{
    class Database
    {
        public List<Pizza> pizzas = new List<Pizza>();
        public List<Ingrediens> ingredienser = new List<Ingrediens>();
        List<Order> orders = new List<Order>();
        MySqlConnection conn;
        MySqlCommand cmd;
        public string dbusername = "test";
        public string dbpassword = "pass";
        public string dbip = "x.x.x.x";
        public string database = "pizza";
        
        public void setup()
        {
            conn = new MySqlConnection(getDBInfo());
            cmd.Connection = conn;
        }
        
        public void open()
        {
            try
            {
                conn.Open();
            }catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void close()
        {
            try
            {
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public string getDBInfo()
        {
            return "server=" + dbip
                + ";uid=" + dbusername
                + ";pwd=" + dbpassword
                + ";database=" + database;
        }

        public void loadAll()
        {
            //Load alt data fra database til hukommelse
            open();
            cmd.CommandText = "SELECT * FROM ingredienser";
            MySqlDataReader rdrIng = cmd.ExecuteReader();
            while (rdrIng.Read())
            {
                ingredienser.Add(new Ingrediens(rdrIng[2].ToString(), int.Parse(rdrIng[3].ToString())));
            }

            cmd.CommandText = "SELECT * FROM pizzaer";
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                string[] ingStr = rdr[3].ToString().Split(',');
                List<Ingrediens> pizzaIngrediens = new List<Ingrediens>();
                foreach(string tempIng in ingStr)
                {
                    tempIng.Replace(" ", "");
                    foreach(Ingrediens ingrediens in ingredienser)
                    {
                        if(tempIng == ingrediens.navn)
                        {
                            pizzaIngrediens.Add(ingrediens);
                        }
                    }

                }
                pizzas.Add(new Pizza(rdr[2].ToString(), pizzaIngrediens, Pizza.Size.NORMAL, Pizza.Dough.Hvidt));
            }
            close();
        }

        public void saveAll()
        {
            //Gem alt data fra hukommelse til database
            open();
            cmd.CommandText = "INSERT INTO pizzaer VALUES(@ingredienser, @prisLille, @prisStor)";
            cmd.Prepare();

            foreach(Pizza pizza in pizzas)
            {
                cmd.Parameters["@ingredienser"].Value = String.Join(",", ingredienser);
                cmd.Parameters["@prisLille"].Value = pizza.getTotalPris();
                cmd.Parameters["@prisStor"].Value = pizza.getTotalPris() * 1.3;
                cmd.ExecuteNonQuery();
            }
            cmd.CommandText = "INSERT INTO ingredienser VALUES(@navn, @pris)";
            foreach(Ingrediens ingrediens in ingredienser)
            {
                cmd.Parameters["@navn"].Value = ingrediens.navn;
                cmd.Parameters["@pris"].Value = ingrediens.pris;
                cmd.ExecuteNonQuery();
            }
            close();
        }
    }
}
