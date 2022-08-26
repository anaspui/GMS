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
using System.Xml.Linq;

namespace GMS
{

    public partial class AddEmployee : Form
    {
        private DataAccess da { get; set; }
        private DataSet ds { get; set; }
        public AddEmployee()
        {
            InitializeComponent();
        }
        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string UserIdGen()
        {
            string newId;
            var sql = "SELECT TOP (1) [Id] FROM [GroceryMSdb].[dbo].[User]  order by Id desc;";
            ds = this.da.ExecuteQuery(sql);
            string lastId = ds.Tables[0].Rows[0]["Id"].ToString();
            string[] data = lastId.Split('-');
            int temp = Convert.ToInt32(data[1]);
            newId = "u-" + (++temp).ToString("d3");
            return newId;
        }
        private bool IsValidToSaveData()
        {
            if (String.IsNullOrEmpty(this.txtUserName.Text) || String.IsNullOrEmpty(this.txtPassword.Text) ||
                String.IsNullOrEmpty(this.txtUserName.Text))
            {
                return false;
            }
            else
                return true;
        }
        private void AddEmp()
        {
            try
            {
                if (!this.IsValidToSaveData())
                {
                    MessageBox.Show("Invalid opration. Please fill up all the information");
                    return;
                }
                else
                {
                    var sql = "insert into [GroceryMSdb].[dbo].[User](Id ,UserName, Password, Name, Role) values ('" + UserIdGen() + "', '" + txtUserName.Text + "', '" + txtPassword.Text + "', '" + txtName.Text + "', 'Employee');";
                    da.ExecuteQuery(sql);
                    this.txtName.Clear();
                    this.txtPassword.Clear();
                    this.txtUserName.Clear();
                    MessageBox.Show("Employee Added Successfully!");
                }
                /*var query = "select * from [GroceryMSdb].[dbo].[User] where UserName = '" + txtUserName.Text.ToString() + "';";
                this.ds = this.da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    var sql = "update [GroceryMSdb].[dbo].[User] set UserName = '" + txtUserName.Text + "', Password = '" + txtPassword.Text + "', Name = '" + txtName.Text + "';";
                    int count = this.da.ExecutiveDMLQuery(sql);

                    if (count == 1)
                    MessageBox.Show("Data updated successfully");
                    else
                        MessageBox.Show("Data upgradation failed");
                }
                else
                {
                    var sql = "insert into [GroceryMSdb].[dbo].[User](Id ,UserName, Password, Name, Role) values ('" + UserIdGen() + "', '" + txtUserName.Text + "', '" + txtPassword.Text + "', '" + txtName.Text + "', 'Employee');";
                    da.ExecuteQuery(sql);
                    this.txtName.Clear();
                    this.txtPassword.Clear();
                    this.txtUserName.Clear();
                }*/
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured" + exc.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEmp();
        }
    }
}
