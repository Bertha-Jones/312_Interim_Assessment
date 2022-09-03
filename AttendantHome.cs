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
    public partial class AttendantHome : Form
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
        public static AttendantHome instance;
        public Label lb1;
        
        public AttendantHome()
        {
            InitializeComponent();
            instance = this;
            lb1 = attendantIDTxt;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void AttendantHome_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userIDTxt.Text !="" & dateTxt.Text !="" & timeTxt.Text != "")
            {
                database.openConnection();
                MySqlCommand command = new MySqlCommand();
                try
                {
                    string countQuery = "select count(*) from  user where userID = '" + userIDTxt.Text + "' and userName = '"+attendantIDTxt.Text+"'";
                    command = new MySqlCommand(countQuery, database.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        string query = "INSERT INTO `till` (`userID`, `date`, `startTime`)VALUES('" + userIDTxt.Text + "','" + dateTxt.Text + "','" + timeTxt.Text + "')";
                        command = new MySqlCommand(@query, database.connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show(userIDTxt.Text + "' has started a till session");

                       
                        string sql = "select * from till where userID = '" + userIDTxt.Text + "' and date = '" + dateTxt.Text + "' and startTime = '" + timeTxt.Text + "' ";
                        command = new MySqlCommand(sql, database.connection);   
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                tillIDTxt.Text = reader["tillID"].ToString();
                            }
                        }
                        database.closeConnection();
                        
                        this.Hide();
                        SalesScreen attendant = new SalesScreen();
                        try
                        {
                            SalesScreen.instance.button.Text = userIDTxt.Text;
                            SalesScreen.instance.button2.Text = timeTxt.Text;
                            SalesScreen.instance.button3.Text = dateTxt.Text;
                            SalesScreen.instance.button4.Text = tillIDTxt.Text;
                            SalesScreen.instance.button5.Text = attendantIDTxt.Text;
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        attendant.ShowDialog();

                    }
                    else
                    {
                        errorLabel2.Visible = true;
                        errorLabel2.Text = "Please enter the appropriate ID for "+ attendantIDTxt.Text+".";
                    }
                }
                catch(Exception ex)
                {
                    errorLabel2.Text = ex.Message;
                }

            }
            else
            {
                errorLabel2.Visible=true;
                errorLabel2.Text = "Please Enter text for all the fields";

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesReportScreenAttendant sales = new SalesReportScreenAttendant();
            sales.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
