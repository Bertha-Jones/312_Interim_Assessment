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
    public partial class CategoryManagementScreen : Form
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
        public CategoryManagementScreen()
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

        private void ProductManagemetButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductManagementScreen user = new ProductManagementScreen();
            user.Show();
        }

        private void stockManagementButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockManagement user = new StockManagement();
            user.Show();
        }

        private void fetchCategoryData()
        {
            string query = "select * from category ";
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
                categoryDataGridView.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void clear() // This function clears input fields after an operation 
        {
            categoryNameTxt.Text = "";
            keyCodeTxt.Text = "";
            descriptionTxt.Text = "";
            //productQuantityTxt.Text = "";
            //categoryTxt.Text = "";

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            database.openConnection();
            MySqlCommand command;

            if (categoryNameTxt.Text != "" & descriptionTxt.Text != "" & keyCodeTxt.Text != "")
            {
                try
                {
                    string countQuery = "select count(*) from  category where categoryName = '" + categoryNameTxt.Text + "' and keyCode ='" + keyCodeTxt + "'";
                    command = new MySqlCommand(countQuery, database.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Product already exist");
                        database.closeConnection();
                    }
                    else
                    {
                        string query = "INSERT INTO `category` (`categoryName`, `description`, `keyCode`) VALUES('" + categoryNameTxt.Text + "','" + descriptionTxt.Text + "','" + keyCodeTxt.Text + "')";
                        command = new MySqlCommand(@query, database.connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show(categoryNameTxt.Text + "' has been successfully added");
                        database.closeConnection();
                        clear();
                        fetchCategoryData();
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

        private void removeButton_Click(object sender, EventArgs e)
        {
            database.openConnection();
            MySqlCommand command;

            if (categoryNameTxt.Text != "" & keyCodeTxt.Text != "")
            {
                try
                {
                    string countQuery = "select count(*) from  category where categoryName = '" + categoryNameTxt.Text + "' ";
                    command = new MySqlCommand(countQuery, database.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        string query = "delete from category where categoryName = '" + categoryNameTxt.Text + "' ";
                        command = new MySqlCommand(@query, database.connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("You have deleted  '" + categoryNameTxt.Text + "' from the system ");
                        database.closeConnection();
                        clear();
                        fetchCategoryData();
                    }
                    else
                    {
                        MessageBox.Show(categoryNameTxt.Text + "' does not  exist in the database");
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

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            database.openConnection();
            MySqlCommand command;

            if (categoryNameTxt.Text != "")
            {
                try
                {
                    string countQuery = "select count(*) from  category where categoryName = '" + categoryNameTxt.Text + "'";
                    command = new MySqlCommand(countQuery, database.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        if (descriptionTxt.Text != "")
                        {
                            string query = "update category set description = '" + descriptionTxt.Text + "' where categoryName = '" + categoryNameTxt.Text + "' ";
                            command = new MySqlCommand(@query, database.connection);
                            command.ExecuteNonQuery();
                        }

                        if (keyCodeTxt.Text != "")
                        {
                            string query = "update category set keyCode = '" + keyCodeTxt.Text + "' where categoryName = '" + categoryNameTxt.Text + "' ";
                            command = new MySqlCommand(@query, database.connection);
                            command.ExecuteNonQuery();
                        }



                        MessageBox.Show(categoryNameTxt.Text + "' has been successfully udated");
                        database.closeConnection();
                        clear();
                        fetchCategoryData();
                    }
                    else
                    {
                        MessageBox.Show(categoryNameTxt.Text + "' does not  exist in the database");
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (categoryNameTxt.Text != "")
            {
                string countQuery = "select * from  category where categoryName = '" + categoryNameTxt.Text + "'";
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
                    categoryDataGridView.DataSource = dv;
                    clear();

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

        private void CategoryManagementScreen_Load(object sender, EventArgs e)
        {
            fetchCategoryData();
          
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdministratorHomeScreen5 admin = new AdministratorHomeScreen5();
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
    }
    
}
