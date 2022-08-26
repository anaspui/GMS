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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;


namespace GMS
{
    public partial class EmpDashPanel : UserControl
    {
        private DataAccess da { get; set; }
        private DataSet ds { get; set; }
        private Panel PnlMain;
        public EmpDashPanel()
        {
            InitializeComponent();
        }


        public EmpDashPanel(Panel PnlMain)
        {
            InitializeComponent();
            da = new DataAccess();
            ds = new DataSet();
            this.PnlMain = PnlMain;
            DashInitiator();
        }
        public void DashInitiator()
        {
            //UnderStock Product List
            var sql = "select ProdId, ProdName, ProdQty from [GroceryMSdb].[dbo].[ProductList] order by ProdQty asc;";
            ds = da.ExecuteQuery(sql);
            dgvProdUnd.AutoGenerateColumns = false;
            dgvProdUnd.DataSource = ds.Tables[0];
            //Total Products
            var Query1 = "select ProdId from ProductList order by ProdId asc;";
            ds = da.ExecuteQuery(Query1);
            txtTotalItms.Text = ds.Tables[0].Rows.Count.ToString();
            txtItems.Text = ds.Tables[0].Rows.Count.ToString();
            //Total Catagory
            txtTotalCat.Text =  totalCat().ToString();
            //item catagory
            txtCat.Text = totalCat().ToString();
            //
            //Total Customers
            var sql4 = "select CusId from [GroceryMSdb].[dbo].[Customer];";
            DataSet ds4 = da.ExecuteQuery(sql4);
            txtTotalCus.Text = ds4.Tables[0].Rows.Count.ToString();
            //Total Orders
            var sql5 = "select OrderId from [GroceryMSdb].[dbo].[Order];";
            DataSet ds5 = da.ExecuteQuery(sql5);
            txtOrders.Text = ds5.Tables[0].Rows.Count.ToString();
            //Total Sells
            var sql6 = "select TotalPrice from [GroceryMSdb].[dbo].[Order];";
            DataSet ds6 = da.ExecuteQuery(sql6);
            double TotalSells = 0;
            for (int i = 0; i < ds6.Tables[0].Rows.Count; i++)
            {
                TotalSells = TotalSells + double.Parse(ds6.Tables[0].Rows[i][0].ToString());
            }
        }
        public int totalCat()
        {
            var Query2 = "select ProdCat from ProductList order by ProdCat asc;";
            ds = da.ExecuteQuery(Query2);
            if (ds.Tables[0].Rows.Count > 0)
            {
                int count = 1;
                ds = da.ExecuteQuery(Query2);
                var lastItem = ds.Tables[0].Rows[0][0].ToString().ToLower();
                
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    if (ds.Tables[0].Rows[i][0].ToString().ToLower() != lastItem)
                    {
                        count++;
                        lastItem = ds.Tables[0].Rows[i][0].ToString().ToLower();
                    }

                }
                return count;
            }
            else return 0;
            
        }
    }
}
