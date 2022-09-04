using MySql.Data.MySqlClient;

namespace InventorySystem2
{
    public partial class LogIn : Form
    {
        public static LogIn? instance;
        public LogIn()
        {
            InitializeComponent();
            instance = this;
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            
            
            database.openConnection();
            MySqlCommand command = new MySqlCommand();
            {
                if (emailTxt.Text != "" & passwordTxt.Text != "" /*& (
                    if (adminButton.Checked) { attendantButton.Visible = false; } else  (attendantButton.Checked) { adminButton.Visible = false; } )*/ )
                {
                    try
                    {

                        string countQuery = "select count(*) from  user where email = '" + emailTxt.Text + "' and password = '"+passwordTxt.Text+"' ";
                        command = new MySqlCommand(countQuery, database.connection);
                        Int32 count = Convert.ToInt32(command.ExecuteScalar());
                        if (count > 0)
                        {

                            /*string query = "select `email` , `password` from user where email = '" + emailTxt.Text + "' and password = '" + passwordTxt.Text + "'";
                            command = new MySqlCommand(@query, database.connection);
                            Int32 countUser = Convert.ToInt32(command.ExecuteScalar());*/

                            /*MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, database.connection);
                            DataTable dt = new DataTable();
                            mySqlDataAdapter.Fill(dt);*/

                            /*if (dt.Rows.Count > 0)(countUser <= 0)*/
                            //{


                                this.Hide();
                                AdministratorHomeScreen admin = new AdministratorHomeScreen();

                                admin.ShowDialog();
                                MessageBox.Show("weldone");



                            }
                            else
                            {
                                errorlbl.Visible = true;
                                errorlbl.Text = "Invalid Password or Email";
                            }
                            //clear();
                            //fetchStudentData();

                        /*}
                        else
                        {
                            errorlbl.Visible = true;
                            errorlbl.Text = "User does not exist";
                        }*/
                        database.closeConnection();
                    }
                    catch (Exception ex)
                    {
                        errorlbl.Text = ex.Message;
                    }
                }
                else
                {
                    errorlbl.Visible = true;
                    errorlbl.Text = "Complete every field";
                }

            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void logInButton_Click_1(object sender, EventArgs e)
        {
            database.openConnection();
            MySqlCommand command = new MySqlCommand();
            {
                if (emailTxt.Text != "" & passwordTxt.Text != "" /*& (
                    if (adminButton.Checked) { attendantButton.Visible = false; } else  (attendantButton.Checked) { adminButton.Visible = false; } )*/ )
                {
                    try
                    { 
                   

                        string countQuery = "select count(*) from  user where email = '" + emailTxt.Text + "' and password = '" + passwordTxt.Text + "' ";
                        command = new MySqlCommand(countQuery, database.connection);
                        Int32 count = Convert.ToInt32(command.ExecuteScalar());
                        if (count > 0)
                        {

                            /*string query = "select `email` , `password` from user where email = '" + emailTxt.Text + "' and password = '" + passwordTxt.Text + "'";
                            command = new MySqlCommand(@query, database.connection);
                            Int32 countUser = Convert.ToInt32(command.ExecuteScalar());*/

                            /*MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, database.connection);
                            DataTable dt = new DataTable();
                            mySqlDataAdapter.Fill(dt);*/

                            /*if (dt.Rows.Count > 0)(countUser <= 0)*/
                            //{

                            if (adminButton.Checked)
                            {
                                string sql = "select * from user where email = '" + emailTxt.Text + "' and password = '" + passwordTxt.Text + "' ";
                                command = new MySqlCommand(sql, database.connection);
                                using (MySqlDataReader reader = command.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        roleTxt.Text = reader["role"].ToString();
                                    }
                                }
                                if(roleTxt.Text == "Administrator")
                                {
                                    
                                    string sql2 = "select * from user where email = '" + emailTxt.Text + "' and password = '" + passwordTxt.Text + "' ";
                                    command = new MySqlCommand(sql2, database.connection);
                                    using (MySqlDataReader reader = command.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            attendantIDTxt.Text = reader["userName"].ToString();
                                        }
                                    }
                                    AdministratorHomeScreen admin = new AdministratorHomeScreen();
                                    try
                                    {
                                        AdministratorHomeScreen.instance.lbadmin.Text = attendantIDTxt.Text;

                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                    this.Hide();
                                    admin.ShowDialog();
                                }
                                else
                                {
                                    MessageBox.Show("Please Select the Attendant Button");
                                }
                            } 
                            else if (attendantButton.Checked)
                            {
                                string sql = "select * from user where email = '" + emailTxt.Text + "' and password = '" + passwordTxt.Text + "' ";
                                command = new MySqlCommand(sql, database.connection);
                                using (MySqlDataReader reader = command.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        roleTxt.Text = reader["role"].ToString();
                                    }
                                }
                                if (roleTxt.Text == "Attendant")
                                {
                                    this.Hide();
                                    string sql2 = "select * from user where email = '" + emailTxt.Text + "' and password = '" + passwordTxt.Text + "' ";
                                    command = new MySqlCommand(sql2, database.connection);
                                    using (MySqlDataReader reader = command.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            attendantIDTxt.Text = reader["userName"].ToString();
                                        }
                                    }
                                    AttendantHome admin = new AttendantHome();
                                    try
                                    {
                                        AttendantHome.instance.lb1.Text = attendantIDTxt.Text;

                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                    admin.ShowDialog();
                                }
                                else
                                {
                                    MessageBox.Show("Please Select the Administrator Button");
                                }
                            }
                            
                            



                        }
                        else
                        {
                            errorlbl.Visible = true;
                            errorlbl.Text = "Invalid Password or Email";
                        }
                        //clear();
                        //fetchStudentData();

                        /*}
                        else
                        {
                            errorlbl.Visible = true;
                            errorlbl.Text = "User does not exist";
                        }*/
                        database.closeConnection();
                    }
                    catch (Exception ex)
                    {
                        errorlbl.Text = ex.Message;
                    }
                }
                else
                {
                    errorlbl.Visible = true;
                    errorlbl.Text = "Complete every field";
                }

            }
        }

        private void roleTxt_Click(object sender, EventArgs e)
        {

        }
    }
}