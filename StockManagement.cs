using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem2
{
    public partial class StockManagement : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,          // To give curved edges to the window
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
        public StockManagement()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }

        private void userManagementButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserManagementScreen user = new UserManagementScreen();
            user.Show();
        }

        private void fetchStockData()
        {
            string query = "select * from stock ";
            DataSet ds = new DataSet();
            DataView dv;
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            try
            {
                database.openConnection();
                MySqlCommand command = new MySqlCommand(query, database.connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                database.closeConnection();

                dv = ds.Tables[0].DefaultView;
                stockDataGridView.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        private void fetchProductData()
        {
            string query = "select * from product ";
            DataSet ds = new DataSet();
            DataView dv;
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            try
            {
                database.openConnection();
                MySqlCommand command = new MySqlCommand(query, database.connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                database.closeConnection();

                dv = ds.Tables[0].DefaultView;
                productDataGridView.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void clear() // This function clears input fields after an operation 
        {
            productNameTxt.Text = "";
            sQuantityTxt.Text = "";
            sUnitPriceTxt.Text = "";
            sTotaltxt.Text = "";
            sDateTimePicker1.Text = "";

        }
        private void ProductManagemetButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductManagementScreen user = new ProductManagementScreen();
            user.Show();
        }

        private void categoryManagementButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CategoryManagementScreen user = new CategoryManagementScreen();
            user.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            database.openConnection();
            MySqlCommand command;

            if (productNameTxt.Text != "" & sUnitPriceTxt.Text != "" & sQuantityTxt.Text != "" & sTotaltxt.Text != "")
            {
                try
                {
                    string countQuery = "select count(*) from  product where productName = '" + productNameTxt.Text + "'  and unitPrice(GHc) = '" + sUnitPriceTxt.Text + " ' ";
                    command = new MySqlCommand(countQuery, database.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        string query = "INSERT INTO `stock` (`productName`, `quantity`, `unitPrice(GHc)`, `total(GHc)`, `dateOfStock`) VALUES ('" + productNameTxt.Text + "','" + sQuantityTxt.Text + "','" + sUnitPriceTxt.Text + "','" + sTotaltxt.Text + "','" + sDateTimePicker1.Text + "')";
                        command = new MySqlCommand(@query, database.connection);
                        command.ExecuteNonQuery();
                        if (sQuantityTxt.Text != "")
                        {
                            string sql = "update product set productQuantity = productQuantity +'" + sQuantityTxt.Text + "' where productName = '" + productNameTxt.Text + "' ";
                            command = new MySqlCommand(@sql, database.connection);
                            command.ExecuteNonQuery();
                        }
                        MessageBox.Show(productNameTxt.Text + " has been successfully stocked up ");
                        database.closeConnection();
                        clear();
                        fetchStockData();
                        
                    }
                    else
                    {
                        MessageBox.Show("Product does not  exist please add to data base");
                        database.closeConnection();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please complete field");
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            database.openConnection();
            MySqlCommand command;

            if (productNameTxt.Text != "")
            {
                try
                {
                    string countQuery = "select count(*) from  stock where productName = '" + productNameTxt.Text + "'and dateOfStock ='" + sDateTimePicker1.Text + "'";
                    command = new MySqlCommand(countQuery, database.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        if (sUnitPriceTxt.Text != "")
                        {
                            string query = "update stock set unitPrice(Ghc) = '" + sUnitPriceTxt.Text + "' where productName = '" + productNameTxt.Text + "' ";
                            command = new MySqlCommand(@query, database.connection);
                            command.ExecuteNonQuery();
                        }

                        if (sQuantityTxt.Text != "")
                        {
                            string query = "update stock set quantity = '" + sQuantityTxt.Text + "' where productName = '" + productNameTxt.Text + "' ";
                            command = new MySqlCommand(@query, database.connection);
                            command.ExecuteNonQuery();
                        }

                        if (sTotaltxt.Text != "")
                        {
                            string query = "update stock set total = '" + sTotaltxt.Text + "' where productName = '" + productNameTxt.Text + "' ";
                            command = new MySqlCommand(@query, database.connection);
                            command.ExecuteNonQuery();
                        }



                        MessageBox.Show(productNameTxt.Text + "' has been successfully udated");
                        database.closeConnection();
                        clear();
                        fetchStockData();
                        fetchProductData();
                    }
                    else
                    {
                        MessageBox.Show(productNameTxt.Text + "' does not  exist in the database");
                        database.closeConnection();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Enter a value for Product Name");
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            database.openConnection();
            MySqlCommand command;

            if (productNameTxt.Text != "" & sQuantityTxt.Text != "")
            {
                try
                {
                    string countQuery = "select count(*) from  stock where productName = '" + productNameTxt.Text + "' ";
                    command = new MySqlCommand(countQuery, database.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        string query = "delete from stock where productName = '" + productNameTxt.Text + "' ";
                        command = new MySqlCommand(@query, database.connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("You have deleted  '" + productNameTxt.Text + "' from the system ");
                        database.closeConnection();
                        clear();
                        fetchStockData();
                        fetchProductData();
                    }
                    else
                    {
                        MessageBox.Show(productNameTxt.Text + "' does not  exist in the database");
                        database.closeConnection();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter the name and the key code of the category  you wish to delete");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (productNameTxt.Text != "")
            {
                string countQuery = "select count(*) from  stock where productName = '" + productNameTxt.Text + "'";
                DataSet ds = new DataSet();
                DataView dv;
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                try
                {
                    database.openConnection();
                    MySqlCommand command = new MySqlCommand(countQuery, database.connection);
                    adapter.SelectCommand = command;
                    adapter.Fill(ds);
                    database.closeConnection();

                    dv = ds.Tables[0].DefaultView;
                    stockDataGridView.DataSource = dv;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            else
            {
                MessageBox.Show("Please enter name of the product you want to search for in the stock section");
            }
        }

        private void StockManagement_Load(object sender, EventArgs e)
        {
            fetchStockData();
            fetchProductData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdministratorHomeScreen admin = new AdministratorHomeScreen();
            admin.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void salesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesReportScreen user = new SalesReportScreen();
            user.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
