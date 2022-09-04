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
    public partial class ProductManagementScreen : Form
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
        public ProductManagementScreen()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
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

        private void userManagementButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserManagementScreen user = new UserManagementScreen();
            user.Show();
        }


        private void categoryManagementButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CategoryManagementScreen user = new CategoryManagementScreen();
            user.Show();
        }

        private void stockManagementButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockManagement user = new StockManagement();
            user.Show();
        }

        private void clear() // This function clears input fields after an operation 
        {
            productNameTxt.Text = "";
            reorderTxt.Text = "";
            productPriceTxt.Text = "";
            productQuantityTxt.Text = "";
            categoryTxt.Text = "";
            
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            database.openConnection();
            MySqlCommand command;

            if (productNameTxt.Text != "" & categoryTxt.Text != "" & productPriceTxt.Text != "" & productQuantityTxt.Text != "" & reorderTxt.Text != "")
            {
                try
                {
                    string countQuery = "select count(*) from  product where productName = '" + productNameTxt.Text + "' and productPrice ='" + productPriceTxt.Text + "'";
                    command = new MySqlCommand(countQuery, database.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Product already exist");
                        database.closeConnection();
                    }
                    else
                    {
                        string query = "INSERT INTO `product` (`productName`, `reorderLevel`, `productPrice`, `categoryName`, `productQuantity`)VALUES('" + productNameTxt.Text + "','" + reorderTxt.Text + "','" + productPriceTxt.Text + "','" + categoryTxt.Text + "','" + productQuantityTxt.Text + "')";
                        command = new MySqlCommand(@query, database.connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show(productNameTxt.Text + "' has been successfully added");
                        database.closeConnection();
                        clear();
                        fetchProductData();
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
                    string countQuery = "select count(*) from  product where productName = '" + productNameTxt.Text + "'";
                    command = new MySqlCommand(countQuery, database.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        if (categoryTxt.Text != "")
                        {
                            string query = "update product set categoryName = '" + categoryTxt.Text + "' where productName = '" + productNameTxt.Text + "' ";
                            command = new MySqlCommand(@query, database.connection);
                            command.ExecuteNonQuery();
                        }

                        if (productPriceTxt.Text != "")
                        {
                            string query = "update product set productPrice = '" + productPriceTxt.Text + "' where productName = '" + productNameTxt.Text + "' ";
                            command = new MySqlCommand(@query, database.connection);
                            command.ExecuteNonQuery();
                        }

                        if (productQuantityTxt.Text != "")
                        {
                            string query = "update product set productQuantity = '" + productQuantityTxt.Text + "' where productName = '" + productNameTxt.Text + "' ";
                            command = new MySqlCommand(@query, database.connection);
                            command.ExecuteNonQuery();
                        }

                        if (reorderTxt.Text != "")
                        {
                            string query = "update product set reorderLevel = '" + reorderTxt.Text + "' where productName = '" + productNameTxt.Text + "' ";
                            command = new MySqlCommand(@query, database.connection);
                            command.ExecuteNonQuery();
                        }


                        MessageBox.Show(productNameTxt.Text + "' has been successfully udated");
                        database.closeConnection();
                        clear();
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

            if (productNameTxt.Text != "" & categoryTxt.Text != "")
            {
                try
                {
                    string countQuery = "select count(*) from  product where productName = '" + productNameTxt.Text + "' and categoryName = '" + categoryTxt.Text + "' ";
                    command = new MySqlCommand(countQuery, database.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        string query = "delete from product where productName = '" + productNameTxt.Text + "' ";
                        command = new MySqlCommand(@query, database.connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("You have deleted  '" + productNameTxt.Text + "' from the system ");
                        database.closeConnection();
                        clear();
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
                MessageBox.Show("Please enter the name and the category of product you wish to delete");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (productNameTxt.Text != "")
            {
                string query = "select * from  product where productName = '" + productNameTxt.Text + "'";
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
                    clear();
                    //fetchProductData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            else
            {
                MessageBox.Show("Please enter name of the product you want to search for");
            }
        }

        private void ProductManagementScreen_Load(object sender, EventArgs e)
        {
            fetchProductData();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdministratorHomeScreen admin = new AdministratorHomeScreen();
            admin.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void salesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesReportScreen user = new SalesReportScreen();
            user.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
