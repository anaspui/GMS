using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using GroceryManagementSystem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GMS
{
    public partial class Login : Form
    {
        private DataAccess Da { get; set; }
        public Login()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        bool IsValidToLogin()
        {
            if (String.IsNullOrEmpty(this.txtUserName.Text) || String.IsNullOrWhiteSpace(this.txtUserName.Text) ||
                String.IsNullOrEmpty(this.txtPassword.Text) || String.IsNullOrWhiteSpace(this.txtPassword.Text))
            {
                return false;
            }
            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!this.IsValidToLogin())
            {
                MessageBox.Show("Please fill the informations");
                return;
            }

            try
            {
                string sql = "select * from dbo.[User];";
                DataSet ds = this.Da.ExecuteQuery(sql);

                int index = 0;
                bool flag = false;
                while (index < ds.Tables[0].Rows.Count)
                {
                    if (this.txtUserName.Text == ds.Tables[0].Rows[index][1].ToString() && this.txtPassword.Text == ds.Tables[0].Rows[index][2].ToString())
                    {
                        //MessageBox.Show("Login Confirmed");
                        flag = true;
                        if (ds.Tables[0].Rows[index][4].ToString() == "Manager")
                        {
                            this.Hide();
                            var Username = ds.Tables[0].Rows[index]["UserName"].ToString();
                            var UserId = ds.Tables[0].Rows[index]["Id"].ToString();
                            Home manager = new Home(Username,UserId);
                            manager.Show();
                        }
                        else
                        {
                            this.Hide();
                            var Username = ds.Tables[0].Rows[index]["UserName"].ToString();
                            var UserId = ds.Tables[0].Rows[index]["Id"].ToString();
                            EmployeeDash empdash = new EmployeeDash(Username, UserId);
                            empdash.Show();
                        }

                        this.txtUserName.Clear();
                        this.txtPassword.Clear();
                        break;
                    }
                    index++;
                }
                if (!flag)
                {
                    MessageBox.Show("No user Found");
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }
    }
}
