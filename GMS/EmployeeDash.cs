using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GMS
{
    public partial  class EmployeeDash: Form
    {
        private EmpDashPanel empDashPanel = new EmpDashPanel();
        public Panel PnlMain
        {
            get { return pnlMain; }
            set { }
        }
        private string UserId;
        private string username;
        public EmployeeDash()
        {
            
            InitializeComponent();
            EmpDashPanel dashObj = new EmpDashPanel(this.pnlMain);
            Employees employees = new Employees(this.pnlMain);
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(dashObj);
            dashObj.Show();

        }

        public EmployeeDash(string username, string UserId)
        {
                InitializeComponent();
                this.UserId = UserId;
                this.username = username;
                lblWelName.Text = username;
                EmpDashPanel dashObj = new EmpDashPanel(this.pnlMain);
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


        private void btnProducts_Click(object sender, EventArgs e)
        {
            EProducts eproducts = new EProducts(this.username);
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(eproducts);
            eproducts.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(UserId);
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(settings);
            settings.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            EmpDashPanel dashObj = new EmpDashPanel(this.pnlMain);
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
