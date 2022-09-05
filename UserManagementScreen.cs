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
    public partial class UserManagementScreen : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,                           // to give curved edges to the window
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
        public UserManagementScreen()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void clear() // This function clears input fields after an operation 
        {
            userNameTxt.Text = "";
            dateTxt.Text = "";
            emailTxt.Text = "";
            phoneNumberTxt.Text = "";
            passwordTxt.Text = "";
            roleTxt.Text = "";
            genderTxt.Text = "";
        }
        private void fetchUsetData()
        {
            string query = "select * from user ";
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
                userDataGridView.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



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

        private void stockManagementButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockManagement user = new StockManagement();
            user.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            database.openConnection();
            MySqlCommand command;

            if (userNameTxt.Text != "" & passwordTxt.Text != "" & emailTxt.Text != "" & phoneNumberTxt.Text != "" & genderTxt.Text != "")
            {
                try
                {
                    string countQuery = "select count(*) from  user where userName = '" + userNameTxt.Text + "' and email ='" + emailTxt.Text + "'";
                    command = new MySqlCommand(countQuery, database.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("User already exist");
                        database.closeConnection();
                    }
                    else
                    {
                        string query = "INSERT INTO `user` (`userName`, `role`, `email`, `password`, `phoneNumber`, `gender`, `dateOfBirth`)VALUES('" + userNameTxt.Text + "','" + roleTxt.Text + "','" + emailTxt.Text + "','" + passwordTxt.Text + "','" + phoneNumberTxt.Text + "','" + genderTxt.Text + "','" + dateTxt.Text + "')";
                        command = new MySqlCommand(@query, database.connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show(userNameTxt.Text + "' has been successfully added");
                        database.closeConnection();
                        clear();
                        fetchUsetData();
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

        private void userDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //fetchUserData();
        }

        private void UserManagementScreen_Load(object sender, EventArgs e)
        {
            fetchUsetData();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            database.openConnection();
            MySqlCommand command;

            if (userNameTxt.Text != "")
            {
                try
                {
                    string countQuery = "select count(*) from  user where userName = '" + userNameTxt.Text + "'";
                    command = new MySqlCommand(countQuery, database.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        if (passwordTxt.Text != "")
                        {
                            string query = "update user set password = '" + passwordTxt.Text + "' where userName = '" + userNameTxt.Text + "' ";
                            command = new MySqlCommand(@query, database.connection);
                            command.ExecuteNonQuery();
                        }

                        if (emailTxt.Text != "")
                        {
                            string query = "update user set email = '" + emailTxt.Text + "' where userName = '" + userNameTxt.Text + "' ";
                            command = new MySqlCommand(@query, database.connection);
                            command.ExecuteNonQuery();
                        }

                        if (phoneNumberTxt.Text != "")
                        {
                            string query = "update user set phoneNumber = '" + phoneNumberTxt.Text + "' where userName = '" + userNameTxt.Text + "' ";
                            command = new MySqlCommand(@query, database.connection);
                            command.ExecuteNonQuery();
                        }

                        if (roleTxt.Text != "")
                        {
                            string query = "update user set role = '" + roleTxt.Text + "' where userName = '" + userNameTxt.Text + "' ";
                            command = new MySqlCommand(@query, database.connection);
                            command.ExecuteNonQuery();
                        }
                        if (genderTxt.Text != "")
                        {
                            string query = "update user set gender = '" + genderTxt.Text + "' where userName = '" + userNameTxt.Text + "' ";
                            command = new MySqlCommand(@query, database.connection);
                            command.ExecuteNonQuery();
                        }
                        if (dateTxt.Text != "")
                        {
                            string query = "update user set dateOfBirth = '" + dateTxt.Text + "' where userName = '" + userNameTxt.Text + "' ";
                            command = new MySqlCommand(@query, database.connection);
                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show(userNameTxt.Text + "' has been successfully udated");
                        database.closeConnection();
                        clear();
                        fetchUsetData();
                    }
                    else
                    {
                        MessageBox.Show("Attendant '" + userNameTxt.Text + "' does not  exist in the database");
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
                MessageBox.Show("Enter a value for the Student ID");
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            database.openConnection();
            MySqlCommand command;

            if (userNameTxt.Text != "" & emailTxt.Text != "")
            {
                try
                {
                    string countQuery = "select count(*) from  user where userName = '" + userNameTxt.Text + "' and email = '" + emailTxt.Text + "' ";
                    command = new MySqlCommand(countQuery, database.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        string query = "delete from user where userName = '" + userNameTxt.Text + "' ";
                        command = new MySqlCommand(@query, database.connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("You have delete attendant '" + userNameTxt.Text + "' from the system ");
                        database.closeConnection();
                        clear();
                        fetchUsetData();
                    }
                    else
                    {
                        MessageBox.Show("Attendant named '" + userNameTxt.Text + "' does not  exist in the database");
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
                MessageBox.Show("Please enter the Id of the student you wish to delete");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            if (userNameTxt.Text != "")
            {
                string query = "select * from  user where userName = '" + userNameTxt.Text + "'";
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
                    userDataGridView.DataSource = dv;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            else
            {
                MessageBox.Show("Please enter name of the user you want to search for");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdministratorHomeScreen5 admin = new AdministratorHomeScreen5();
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
    }
}
