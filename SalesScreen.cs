using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem2
{
    public partial class SalesScreen : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
        public static SalesScreen instance;
        public Label button;
        public Label button2;
        public Label button3;
        public Label button4;
        public Label button5;
        public SalesScreen()
        {
            InitializeComponent();
            instance = this;
            button = userIDTxt;
            button2 = startTimeTxt;
            button3 = dateTxt;
            button4 = tillIDTxt;
            button5 = attendantNameTxt;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }
        private void fetchSalesData()
        {
            string query = "select * from sales where tillID = '"+tillIDTxt.Text+"' ";
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

        private void addButton_Click(object sender, EventArgs e)
        {
            //string query ="UPDATE `product` set `quantity`  = `quantity` - '"++"' WHERE BookID = TheIdForTheBookHeBorrowed";
            database.openConnection();
            MySqlCommand command;
            if (productNameTxt.Text !="" & saleQuantityTxt.Text !="" & sTotaltxt.Text !="" & sUnitPriceTxt.Text != "")
            {
                int num1,num2, res;
                num1= Convert.ToInt32(saleQuantityTxt.Text);
                num2= Convert.ToInt32(sUnitPriceTxt.Text);
                res = num1 * num2;
                sTotaltxt.Text = Convert.ToString(res);
                /*try
                {
                    
                    string countQuery = "select count(*) from product where productQuantity <=0 ";
                    command = new MySqlCommand(countQuery, database.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Out of Stock");
                        database.closeConnection();
                    }
                    else
                    {*/
                        string query = "insert into `sales` (`productName`, `productPrice`, `amount`, `total`, `tillID`) values ('" + productNameTxt.Text + "', '" + sUnitPriceTxt.Text + "','" + saleQuantityTxt.Text + "','" + sTotaltxt.Text + "','" + tillIDTxt.Text + "')";
                        command = new MySqlCommand(query, database.connection);
                        command.ExecuteNonQuery();
                        if (saleQuantityTxt.Text != "")
                        {
                            string sql = "update product set productQuantity = productQuantity -'" + saleQuantityTxt.Text + "' where productName = '" + productNameTxt.Text + "' ";
                            command = new MySqlCommand(@sql, database.connection);
                            command.ExecuteNonQuery();
                        }
                        if (saleQuantityTxt.Text != "")
                        {
                            string sql = "select count(*) from product where productQuantity <= reorderLevel ";
                            command = new MySqlCommand(@sql, database.connection);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Please reOrder");
                        }
                        MessageBox.Show("added to Sales");
                        database.closeConnection();
                        fetchSalesData();
                        fetchProductData();
                    /*}
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }*/
                /*if (saleQuantityTxt.Text !="")
                {
                    
                }
                else
                {
                    string query = "insert into `sales` (`productName`, `productPrice`, `amount`, `total`, `tillID`) values ('" + productNameTxt.Text + "', '" + sUnitPriceTxt.Text + "','" + saleQuantityTxt.Text + "','" + sTotaltxt.Text + "','" + tillIDTxt.Text + "')";
                    command = new MySqlCommand(query, database.connection);
                    command.ExecuteNonQuery();
                    if (saleQuantityTxt.Text != "")
                    {
                        string sql = "update product set productQuantity = productQuantity -'" + saleQuantityTxt.Text + "' where productName = '" + productNameTxt.Text + "' ";
                        command = new MySqlCommand(@sql, database.connection);
                        command.ExecuteNonQuery();
                    }
                    if (saleQuantityTxt.Text != "")
                    {
                        string sql = "select count(*) from product where productQuantity <= reorderLevel ";
                        command = new MySqlCommand(@sql, database.connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Please reOrder");
                    }
                    MessageBox.Show("added to Sales");
                    database.closeConnection();
                    fetchSalesData();
                    fetchProductData();

                }*/
            }
            else
            {
                MessageBox.Show("Please complete every field");
            }
        }

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0 )
            {
                DataGridViewRow row = productDataGridView.Rows[e.RowIndex];
                productNameTxt.Text = row.Cells["productName"].Value.ToString();
                sUnitPriceTxt.Text = row.Cells["productPrice"].Value.ToString();
                sTotaltxt.Text = row.Cells["productPrice"].Value.ToString();
            }
        }

        private void SalesScreen_Load(object sender, EventArgs e)
        {
            fetchProductData();
            fetchSalesData();
        }

        private void stockManagementButton_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void userIDTxt_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            database.openConnection();
            MySqlCommand command;

            string query = "UPDATE `till` SET `endTime` = '"+closeTimeTxt.Text+"' , `totalMade` = '"+sTotaltxt.Text+"' , `tillStatus` = 'Closed' WHERE `till`.`tillID` = '"+tillIDTxt.Text+"';";
            command = new MySqlCommand(query,database.connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully ended session");
            database.closeConnection();

            this.Hide();
            LogIn attend = new LogIn();
            attend.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stockDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void attendantNameTxt_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Sale Reciept", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(240, 40));

            e.Graphics.DrawString("=================================================================================================", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(240, 40));


        }

        private void button6_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
