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
    public partial class AdministratorHomeScreen5 : Form
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
        public static AdministratorHomeScreen5 instance;
        public Label lbadmin;
        public AdministratorHomeScreen5()
        {
            InitializeComponent();
            instance = this;
            lbadmin = adminNameTxt;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }

        private void AdministratorHomeScreen_Load(object sender, EventArgs e)
        {

        }

        private void userManagementButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserManagementScreen user = new UserManagementScreen();
            user.Show();
        }

        private void salesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesReportScreen user = new SalesReportScreen();
            user.Show();
        }

        private void stockManagementButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockManagement user = new StockManagement();
            user.Show();
        }

        private void categoryManagementButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CategoryManagementScreen user = new CategoryManagementScreen();
            user.Show();
        }

        private void ProductManagemetButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductManagementScreen user = new ProductManagementScreen();
            user.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
