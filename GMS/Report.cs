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
    public partial class Report : UserControl
    {
        private DataAccess da { get; set; }
        private DataSet ds { get; set; }
        public Report()
        {
            InitializeComponent();
            da = new DataAccess();
            ds = new DataSet();
            var sql = "select * FROM [GroceryMSdb].[dbo].[Order];";
            ds = da.ExecuteQuery(sql);
            this.dgvReport.DataSource = ds.Tables[0];
        }
        private void Refresh()
        {
            da = new DataAccess();
            ds = new DataSet();
            var sql = "select * FROM [GroceryMSdb].[dbo].[Order];";
            ds = da.ExecuteQuery(sql);
            this.dgvReport.DataSource = ds.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string EmployeeId = txtByEmp.Text.ToString();
            da = new DataAccess();
            ds = new DataSet();
            var sql = "select * FROM [GroceryMSdb].[dbo].[Order] where EmpId = '"+EmployeeId+"';";
            ds = da.ExecuteQuery(sql);
            this.dgvReport.DataSource = ds.Tables[0];
        }
 

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
