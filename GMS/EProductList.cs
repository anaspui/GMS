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
    public partial class EProductList : Form
    {
        private DataAccess da { get; set; }
        private DataSet ds { get; set; }
        private string username;
        public EProductList()
        {
            InitializeComponent();
            da = new DataAccess();
            ds = new DataSet();
            var sql = "select * from [GroceryMSdb].[dbo].[ProductList] order by ProdId asc;";
            ds = da.ExecuteQuery(sql);
            this.dgvProdList.AutoGenerateColumns = false;
            this.dgvProdList.DataSource = ds.Tables[0];
            txtProdId.Text = ProductIdGen();
            lblDate.Text = DateTime.Now.ToString("MM/dd/yyyy");

        }
        public EProductList(string username)
        {
            InitializeComponent();
            this.username = username;
            da = new DataAccess();
            ds = new DataSet();
            var sql = "select * from [GroceryMSdb].[dbo].[ProductList] order by ProdId asc;";
            ds = da.ExecuteQuery(sql);
            this.dgvProdList.AutoGenerateColumns = false;
            this.dgvProdList.DataSource = ds.Tables[0];
            txtProdId.Text = ProductIdGen();
            lblDate.Text = DateTime.Now.ToString("MM/dd/yyyy");

        }
        public void Refresh(string sql = "select * from [GroceryMSdb].[dbo].[ProductList] order by ProdId asc;")
        {
            DataSet ds = this.da.ExecuteQuery(sql);
            this.dgvProdList.AutoGenerateColumns = false;
            this.dgvProdList.DataSource = ds.Tables[0];
        }
        public string ProductIdGen()
        {
            string newId;
            var sql = "SELECT TOP (1) [ProdId] FROM [GroceryMSdb].[dbo].[ProductList]  order by ProdId desc;";
            ds = this.da.ExecuteQuery(sql);
            string lastId = ds.Tables[0].Rows[0]["ProdId"].ToString();
            string[] data = lastId.Split('-');
            int temp = Convert.ToInt32(data[1]);
            newId = "p-" + (++temp).ToString("d3");
            this.txtProdId.Text = newId;
            return newId;
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            var ds = da.ExecuteQuery("select * from [GroceryMSdb].[dbo].[ProductList] order by ProdId asc;");
            this.dgvProdList.AutoGenerateColumns = false;
            this.dgvProdList.DataSource = ds.Tables[0];
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtProdId.Text = ProductIdGen();
            this.txtProdName.Clear();
            this.txtProdCat.Clear();
            this.txtProdPrice.Clear();
            this.NumQty.Value = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSaveData())
                {
                    MessageBox.Show("Invalid opration. Please fill up all the information");
                    return;
                }

                var query = "select * from ProductList where ProdId = '" + this.txtProdId.Text + "';";
                this.ds = this.da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    var currentDate = DateTime.Now.ToString("MM/dd/yyyy");
                    //update
                    var sql = "update ProductList set ProdId = '" + txtProdId.Text + "', ProdName = '" + txtProdName.Text + "', ProdPrice = " + Double.Parse(txtProdPrice.Text) + ", ProdQty = " + NumQty.Value + ", DateAdded = '" + currentDate + "' where ProdId = '" + txtProdId.Text + "';";
                    int count = this.da.ExecutiveDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data updated successfully");
                    else
                        MessageBox.Show("Data upgradation failed");
                }

                else
                {
                    var currentDate = DateTime.Now.ToString("MM/dd/yyyy");
                    var sql = "insert into ProductList( ProdId, ProdName, ProdPrice, ProdQty, ProdCat, DateAdded) values ('" + txtProdId.Text + "', '" + txtProdName.Text + "', " + Double.Parse(txtProdPrice.Text) + ", " + Int32.Parse(NumQty.Text) + ", '" + txtProdCat.Text + "', '" + currentDate + "');";
                    da.ExecuteQuery(sql);
                    this.ds = da.ExecuteQuery("select * from [GroceryMSdb].[dbo].[ProductList];");
                    this.dgvProdList.AutoGenerateColumns = false;
                    this.dgvProdList.DataSource = ds.Tables[0];
                    this.Refresh();
                    this.txtProdId.Text = ProductIdGen();
                    this.txtProdName.Clear();
                    this.txtProdCat.Clear();
                    this.txtProdPrice.Clear();
                    this.NumQty.Value = 0;
                }
                this.ds = da.ExecuteQuery("select * from [GroceryMSdb].[dbo].[ProductList];");
                this.dgvProdList.AutoGenerateColumns = false;
                this.dgvProdList.DataSource = ds.Tables[0];
                this.Refresh();
            }
            catch(Exception exc)
            {
                MessageBox.Show("An error has occured" + exc.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            if (this.dgvProdList.SelectedRows.Count < 1)
            {
                MessageBox.Show("Select a row first");
                return;
            }

            string Id = this.dgvProdList.CurrentRow.Cells["ProdId"].Value.ToString();

            try
            {
                string sql = "delete from ProductList where ProdId = '" + Id + "';";
                int result = this.da.ExecutiveDMLQuery(sql);
                if (result == 1)
                {
                    MessageBox.Show(Id + " Removed");
                }
                else
                {
                    MessageBox.Show("Operation Failed");
                }

                this.Refresh();
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void dgvProductList_DoubleClick(object sender, EventArgs e)
        {
            this.txtProdId.Text = this.dgvProdList.CurrentRow.Cells["ProdId"].Value.ToString();
            this.txtProdName.Text = this.dgvProdList.CurrentRow.Cells["ProdName"].Value.ToString();
            this.txtProdCat.Text = this.dgvProdList.CurrentRow.Cells["ProdCat"].Value.ToString();
            this.txtProdPrice.Text = this.dgvProdList.CurrentRow.Cells["ProdPrice"].Value.ToString();
            this.NumQty.Value = Int32.Parse(this.dgvProdList.CurrentRow.Cells["ProdQty"].Value.ToString());
        }
        private bool IsValidToSaveData()
        {
            if (String.IsNullOrEmpty(this.txtProdId.Text) || String.IsNullOrEmpty(this.txtProdName.Text) ||
                String.IsNullOrEmpty(this.txtProdCat.Text) || String.IsNullOrEmpty(this.txtProdPrice.Text) || String.IsNullOrWhiteSpace(this.NumQty.Text))
            {
                return false;
            }
            else
                return true;
        }
    }
}
