using GroceryManagementSystem;
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
    public partial class Settings : UserControl
    {
        private DataAccess da { get; set; }
        private DataSet ds { get; set; }
        public Settings()
        {
            InitializeComponent();
            da = new DataAccess();
            ds = new DataSet();
        }
        private string userId;
        public Settings(string userId)
        {
            this.userId = userId;
            InitializeComponent();
            da = new DataAccess();
            ds = new DataSet();
        }
        private bool IsValidToSaveData()
        {
            if (String.IsNullOrEmpty(this.txtName.Text) || String.IsNullOrEmpty(this.txtPassword.Text) ||
                String.IsNullOrEmpty(this.txtUserName.Text))
            {
                return false;
            }
            else
                return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!this.IsValidToSaveData())
            {
                MessageBox.Show("Please fill up all the information", "Error!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string UserName = txtUserName.Text.ToString();
            string Name = txtName.Text.ToString();
            string Password = txtPassword.Text.ToString();
            DialogResult dialogResult = MessageBox.Show("Do you want to update your informations?", "Update?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ds = da.ExecuteQuery("UPDATE [GroceryMSdb].[dbo].[User] SET UserName = '" + UserName + "', Name = '" + Name + "', Password = '" + Password + "' WHERE Id = '" + userId + "';");
                txtName.Clear();
                txtPassword.Clear();
                txtUserName.Clear();
                MessageBox.Show("Please log back in with new credentials", "Informations Updated",
                MessageBoxButtons.OK);
                Application.Restart();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Cancelled by user", "Cancelled",
                MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("An Unexpected Error Occured", "Upgradation Failed",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
