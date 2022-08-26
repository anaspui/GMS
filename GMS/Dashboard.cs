using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMS
{
    public partial  class Home : Form
    {
        private Dash dash = new Dash();
        public Panel PnlMain
        {
            get { return pnlMain; }
            set { }
        }
        private string UserId;
        public Home()
        {
            
            InitializeComponent();
            Dash dashObj = new Dash(this.pnlMain);
            Employees employees = new Employees(this.pnlMain);
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(dashObj);
            dashObj.Show();
        }
        public Home(string username, string UserId)
        {
                InitializeComponent();
                this.UserId = UserId;
                lblWelName.Text = username;
                Dash dashObj = new Dash(this.pnlMain);
                Employees employees = new Employees(this.pnlMain);
                this.pnlMain.Controls.Clear();
                this.pnlMain.Controls.Add(dashObj);
                dashObj.Show();
        }
        
        private void btnOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(order);
            order.Show();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees(this.pnlMain);
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(employees);
            employees.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(products);
            products.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(UserId);
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(settings);
            settings.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(report);
            report.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dash dashObj = new Dash(this.pnlMain);
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(dashObj);
            dashObj.Show();
        }


        private void pictureBox8_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to logout?", "Logout?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Log out succesfull!");
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to logout?", "Logout?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Log out succesfull!");
                this.Close();
                Application.Restart();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}
