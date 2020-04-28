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
        public string dbip = "136.243.20.226";
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

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM pizzaer";
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                //pizzas.Add(new Pizza(rdr[1]));
            }
        }

        public void saveAll()
        {
            //Gem alt data fra hukommelse til database
        }
    }
}
