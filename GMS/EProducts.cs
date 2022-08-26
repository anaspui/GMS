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
using System.Data.SqlClient;

namespace GMS
{
    public partial class EProducts : UserControl
    {
        private DataAccess da { get; set; }
        private DataSet ds { get; set; }
        private string username;
        public EProducts()
        {
            InitializeComponent();
            da = new DataAccess();
            ds = new DataSet();
            txtProdId.Text = ProductIdGen();
        }
        public EProducts(string username)
        {
            InitializeComponent();
            this.username = username;
            da = new DataAccess();
            ds = new DataSet();
            txtProdId.Text = ProductIdGen();
        }

        private void Products_Load(object sender, EventArgs e)
        {

        }

        private void btnProdList_Click(object sender, EventArgs e)
        {
            EProductList eproductList = new EProductList(this.username);
            eproductList.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
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

                        MessageBox.Show("Error! Items Exist With The Given Product ID");
                }

                else
                {
                    var currentDate = DateTime.Now.ToString("MM/dd/yyyy");
                    var sql = "insert into ProductList( ProdId, ProdName, ProdPrice, ProdQty, ProdCat, DateAdded) values ('" + txtProdId.Text + "', '" + txtProdName.Text + "', " + Double.Parse(txtProdPrice.Text) + ", " + Int32.Parse(numQty.Text) + ", '" + txtProdCat.Text + "', '" + currentDate + "');";
                    da.ExecuteQuery(sql);
                    this.txtProdId.Text = ProductIdGen();
                    this.txtProdName.Clear();
                    this.txtProdCat.Clear();
                    this.txtProdPrice.Clear();
                    this.numQty.Value = 0;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured" + exc.Message);
            }
        }
        private bool IsValidToSaveData()
        {
            if (String.IsNullOrEmpty(this.txtProdId.Text) || String.IsNullOrEmpty(this.txtProdName.Text) ||
                String.IsNullOrEmpty(this.txtProdCat.Text) || String.IsNullOrEmpty(this.txtProdPrice.Text) || String.IsNullOrWhiteSpace(this.numQty.Text))
            {
                return false;
            }
            else
                return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtProdId.Text = ProductIdGen();
            this.txtProdName.Clear();
            this.txtProdCat.Clear();
            this.txtProdPrice.Clear();
            this.numQty.Value = 0;
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
    }
}
