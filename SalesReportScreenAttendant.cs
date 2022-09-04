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
    public partial class SalesReportScreenAttendant : Form
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
        public SalesReportScreenAttendant()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }


        private void clear() // This function clears input fields after an operation 
        {
            tillIDTxt.Text = "";

            //productQuantityTxt.Text = "";
            //categoryTxt.Text = "";

        }
        private void button3_Click(object sender, EventArgs e)
        {

            if (tillIDTxt.Text != "")
            {
                string query = "select * from sales where tillID = '" + tillIDTxt.Text + "'";
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
                    salesDataGridView.DataSource = dv;
                    clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter till ID");
            }
        }

        

        private void SalesReportScreen_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AttendantHome attend = new AttendantHome();
            attend.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SalesReportScreenAttendant_Load(object sender, EventArgs e)
        {

        }
    }
}
