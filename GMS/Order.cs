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
    public partial class Order : UserControl
    {
        private DataAccess da { get; set; }
        private DataSet ds { get; set; }
        private string UserId;
        public Order()
        {
            InitializeComponent();
            da = new DataAccess();
            ds = new DataSet();
            Refresh();
            CusIdGen();
            OrderIdGen();
            dvgSelProdListRefresh();
            //dgvProdList.RowsDefaultCellStyle.ForeColor = Color.Black;
           // dgvSelProd.RowsDefaultCellStyle.ForeColor = Color.Black;
        }
        public Order(string UserId)
        {
            InitializeComponent();
            this.UserId = UserId;
            da = new DataAccess();
            ds = new DataSet();
            Refresh();
            CusIdGen();
            OrderIdGen();
            dvgSelProdListRefresh();
            //dgvProdList.RowsDefaultCellStyle.ForeColor = Color.Black;
            //dgvSelProd.RowsDefaultCellStyle.ForeColor = Color.Black;
        }
        public void Refresh(string sql = "select ProdId, ProdName, ProdPrice, ProdQty, ProdCat from [GroceryMSdb].[dbo].[ProductList] order by ProdId asc;")
        {
            DataSet ds = this.da.ExecuteQuery(sql);
            this.dgvProdList.AutoGenerateColumns = false;
            this.dgvProdList.DataSource = ds.Tables[0];
            lblPurchaseDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }
        public void CleanSelectedProductList(string sql = "DELETE FROM SelectedProducts;")
        {

        }
        private bool IsValidToSaveData()
        {
            if (String.IsNullOrEmpty(this.txtCusId.Text) || String.IsNullOrEmpty(this.txtCusName.Text) ||
                String.IsNullOrEmpty(this.txtCusPhn.Text) || String.IsNullOrEmpty(this.txtNumUpDown.Text) || String.IsNullOrEmpty(this.txtOrderId.Text))
            {
                return false;
            }
            else
                return true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.dgvSelProd.SelectedRows.Count < 1)
            {
                MessageBox.Show("Select a product to remove");
                return;
            }

            string Id = this.dgvSelProd.CurrentRow.Cells["SelProdId"].Value.ToString();

            try
            {
                string sql = "delete from SelectedProducts where SelProdId = '" + Id + "';";
                int result = this.da.ExecutiveDMLQuery(sql);
                if (result == 1)
                {
                    MessageBox.Show(Id + " Removed");
                    dvgSelProdListRefresh();
                }
                else
                {
                    MessageBox.Show("Operation Failed");
                    dvgSelProdListRefresh();
                }

                this.Refresh();
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }
        public void dvgSelProdListRefresh(string sql = "select * from SelectedProducts;")
        {
            DataSet ds = this.da.ExecuteQuery(sql);
            this.dgvSelProd.AutoGenerateColumns = false;
            this.dgvSelProd.DataSource = ds.Tables[0];
        }


        private void dgvProductList_DoubleClick(object sender, EventArgs e)
        {
            dvgSelProdListRefresh();
            var ProdId = this.dgvProdList.CurrentRow.Cells["ProdId"].Value.ToString();
            var ProdName = this.dgvProdList.CurrentRow.Cells["ProdName"].Value.ToString();
            int ProdQty = (int)txtNumUpDown.Value;
            var ProdPrice = this.dgvProdList.CurrentRow.Cells["ProdPrice"].Value.ToString();
            double TotalPricePerQty = ProdQty * double.Parse(ProdPrice);
            DataAccess da = new DataAccess();
            var sql = "insert into SelectedProducts( SelProdId, SelProdName, SelProdQty, SelProdPrice) values ('"+ProdId+"', '"+ProdName+"', "+ProdQty+", "+ TotalPricePerQty + ");";
            da.ExecuteQuery(sql);
            
            //
            var sql2 = "select * from SelectedProducts;";
            ds = da.ExecuteQuery(sql2);
            this.dgvSelProd.AutoGenerateColumns = false;
            this.dgvSelProd.DataSource = ds.Tables[0];
            ds = da.ExecuteQuery("select * from SelectedProducts;");
            double TotalPrice = 0;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                TotalPrice = TotalPrice + double.Parse(ds.Tables[0].Rows[i]["SelProdPrice"].ToString());
            }
            lblTotal.Text = TotalPrice.ToString();
            dvgSelProdListRefresh();
        }
        public string CusIdGen()
        {
            string newId;
            var sql = "SELECT TOP (1) CusId FROM Customer order by CusId desc;";
            ds = this.da.ExecuteQuery(sql);
            string lastId = ds.Tables[0].Rows[0]["CusId"].ToString();
            string[] data = lastId.Split('-');
            int temp = Convert.ToInt32(data[1]);
            newId = "c-" + (++temp).ToString("d3");
            this.txtCusId.Text = newId;
            return newId;
        }
        public string OrderIdGen()
        {
            string newId;
            var sql = "SELECT TOP (1) [OrderId] FROM [GroceryMSdb].[dbo].[Order] order by OrderId desc;";
            ds = this.da.ExecuteQuery(sql);
            string lastId = ds.Tables[0].Rows[0]["OrderId"].ToString();
            string[] data = lastId.Split('-');
            int temp = Convert.ToInt32(data[1]);
            newId = "o-" + (++temp).ToString("d3");
            this.txtOrderId.Text = newId;
            return newId;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            da.ExecuteQuery("delete from SelectedProducts;");
            txtCusPhn.Clear();
            txtCusName.Clear();
            txtNumUpDown.Value = 1;
            CusIdGen();
            OrderIdGen();
            dvgSelProdListRefresh();
        }
        DataSet prevQtyOfSelProd;
        private void btnCheckOut_Click(object sender, EventArgs e)
        {



            DialogResult dialogResult = MessageBox.Show("Do you want to confirm this purchase?", "Confirm Purchase?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var OrderID = OrderIdGen();
                var CusID = CusIdGen();
                var CusName = txtCusName.Text;
                var Phone = txtCusPhn.Text;
                ds = da.ExecuteQuery("select * from SelectedProducts;");
                double TotalPrice = 0;
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    TotalPrice = TotalPrice + double.Parse(ds.Tables[0].Rows[i]["SelProdPrice"].ToString());
                }
                da.ExecuteQuery("insert into [GroceryMSdb].[dbo].[Order] (OrderId, CusId, EmpId, DateSold, TotalPrice, CusName) values ('" + OrderID + "','" + CusID + "','" + UserId + "', '" + DateTime.Now.ToString("MM/dd/yyyy") + "', " + TotalPrice + ", '" + CusName + "');");
                da.ExecuteQuery("insert into Customer(CusId, CusName, OrderId, CusPhone) values ('" + CusID + "', '" + CusName + "', '" + OrderID + "', '" + Phone + "');");
                da.ExecuteQuery("delete from SelectedProducts;");
                txtCusPhn.Clear();
                txtCusName.Clear();
                lblTotal.Text = "0.00";
                txtNumUpDown.Value = 1;
                CusIdGen();
                OrderIdGen();
                dvgSelProdListRefresh();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Purchase Cancelled", "Cancelled",
                MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("An Unexpected Error Occured", "Purchase Failed",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //////////////////////////////////////////////////////////////////////////////
            //sel qty
            var sql10 = "select SelProdQty from [GroceryMSdb].[dbo].[SelectedProducts] order by SelProdId;";
            DataSet ds10 = da.ExecuteQuery(sql10);
            //selected products qty by id
            var sql11 = "select SelProdId from [GroceryMSdb].[dbo].[SelectedProducts] order by SelProdId;";
            DataSet ds11 = da.ExecuteQuery(sql11);
            //prev qty
           
            for (int i = 0; i < ds11.Tables[0].Rows.Count; i++)
            {
                var sql12 = "select ProdQty from [GroceryMSdb].[dbo].[ProductList] where ProdId = '" + ds11.Tables[0].Rows[i][0].ToString() + "' order by ProdId;";
                prevQtyOfSelProd.Tables[0].Rows[i][0] = da.ExecuteQuery(sql12);
                
            }
            for(int i = 0; i < ds11.Tables[0].Rows.Count; i++)
            {
                int p = Int32.Parse(prevQtyOfSelProd.Tables[0].Rows[i][0].ToString());
                int s = Int32.Parse(ds10.Tables[0].Rows[i][0].ToString());
                var sql = "UPDATE ProductList SET ProdQty = " + (p-s) + " where ProdId = '" + ds11.Tables[0].Rows[i][0].ToString() +"';";
                da.ExecuteQuery(sql);
            }
            
           ///////// price = price + double.Parse(ds10.Tables[0].Rows[0][0].ToString());//////////////////////////////////////////////
            


            /*var OrderID = OrderIdGen();
            var CusID = CusIdGen();
            var CusName = txtCusName.Text;
            var Phone = txtCusPhn.Text;
            ds = da.ExecuteQuery("select * from SelectedProducts;");
            double TotalPrice = 0;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
               TotalPrice = TotalPrice + double.Parse(ds.Tables[0].Rows[i]["SelProdPrice"].ToString());
            }
            da.ExecuteQuery("insert into [GroceryMSdb].[dbo].[Order] (OrderId, CusId, EmpId, DateSold, TotalPrice, CusName) values ('"+OrderID+"','"+ CusID + "','"+UserId+"', '"+ DateTime.Now.ToString("MM/dd/yyyy") + "', "+TotalPrice+", '"+CusName+"');");
            da.ExecuteQuery("insert into Customer(CusId, CusName, OrderId, CusPhone) values ('"+CusID+"', '"+CusName+"', '"+OrderID+"', '"+Phone+"');");
            da.ExecuteQuery("delete from SelectedProducts;");
            txtCusPhn.Clear();
            txtCusName.Clear();
            lblTotal.Text = "0.00";
            txtNumUpDown.Value = 1;
            CusIdGen();
            OrderIdGen();
            dvgSelProdListRefresh();*/
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
