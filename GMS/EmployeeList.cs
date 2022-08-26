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
    public partial class EmployeeList : UserControl
    {
        private DataAccess da { get; set; }
        private DataSet ds { get; set; }
        public EmployeeList()
        {
            InitializeComponent();
            da = new DataAccess();
            ds = new DataSet();
            var sql = "select * FROM [GroceryMSdb].[dbo].[User] where Role = 'Employee';";
            ds = da.ExecuteQuery(sql);
            this.dgvUserList.DataSource = ds.Tables[0];

        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSaveData())
                {
                    MessageBox.Show("Invalid opration. Please fill up all the information");
                    return;
                }

                var query = "select * from [GroceryMSdb].[dbo].[User] where UserName = '"+txtUserName+"';";
                this.ds = this.da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    var currentDate = DateTime.Now.ToString("MM/dd/yyyy");
                    //update
                    var sql = "update [GroceryMSdb].[dbo].[User] set UserName = '" + txtUserName.Text + "', Password = '" + txtPassword.Text + "', Name = '" + txtName.Text + "';";
                    int count = this.da.ExecutiveDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data updated successfully");
                    else
                        MessageBox.Show("Data upgradation failed");
                }

                else
                {
                    var sql = "insert into [GroceryMSdb].[dbo].[User](Id ,UserName, Password, Name, Role) values ('" + UserIdGen() +"', '"+txtUserName.Text+"', '"+txtPassword.Text+"', '"+txtName.Text+"', 'Employee');";
                    da.ExecuteQuery(sql);
                    this.ds = da.ExecuteQuery("select * FROM [GroceryMSdb].[dbo].[User];");
                    this.dgvUserList.AutoGenerateColumns = false;
                    this.dgvUserList.DataSource = ds.Tables[0];
                    this.Refresh();
                    this.txtName.Clear();
                    this.txtPassword.Clear();
                    this.txtUserName.Clear();
                }
                this.ds = da.ExecuteQuery("select * FROM [GroceryMSdb].[dbo].[User];");
                this.dgvUserList.AutoGenerateColumns = false;
                this.dgvUserList.DataSource = ds.Tables[0];
                this.Refresh();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured" + exc.Message);
            }
        }
        public void Refresh(string sql = "select * from [GroceryMSdb].[dbo].[User] order by Id asc;")
        {
            DataSet ds = this.da.ExecuteQuery(sql);
            this.dgvUserList.AutoGenerateColumns = false;
            this.dgvUserList.DataSource = ds.Tables[0];
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
            if (String.IsNullOrEmpty(this.txtName.Text) || String.IsNullOrEmpty(this.txtPassword.Text) ||
                String.IsNullOrEmpty(this.txtUserName.Text))
            {
                return false;
            }
            else
                return true;
        }

        
    }
}
