using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace InventorySystem2
{
    internal class database
    {
        public static string connectionString = "server=localhost ; database=inventorysystem ; uid=root ; password=\"\"; convert zero datetime=True ;";
        public static MySqlConnection connection = new MySqlConnection(connectionString);

        //here we call a function to open and close the connection to the database

        public static void openConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                    MessageBox.Show("Connection Opened Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void closeConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);            }
        }
    }
}
