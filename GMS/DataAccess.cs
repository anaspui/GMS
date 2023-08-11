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

namespace GroceryManagementSystem
{
    class DataAccess
    {
        private SqlConnection sqlCon;
        public SqlConnection SqlCon
        {
            get { return this.sqlCon; }
            set { this.sqlCon = value; }
        }

        private SqlCommand sqlCom;
        public SqlCommand SqlCom
        {
            get { return this.sqlCom; }
            set { this.sqlCom = value; }
        }

        private SqlDataAdapter sda;
        public SqlDataAdapter Sda
        {
            get { return this.sda; }
            set { this.sda = value; }
        }

        private DataSet ds;
        public DataSet Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }

        public DataAccess()
        {
            this.SqlCon = new SqlConnection("Data Source=THE-BUG\\SQLEXPRESS;Initial Catalog=GroceryMSdb;Persist Security Info=True;User ID=anas;Password=sa");
            SqlCon.Open();
        }

        private void QueryText(string query)
        {
            this.sqlCom = new SqlCommand(query, this.SqlCon);
        }

        public DataSet ExecuteQuery(string sql)
        {
            this.QueryText(sql);
            try
            {
                this.Sda = new SqlDataAdapter(this.SqlCom);
                this.Ds = new DataSet();
                this.Sda.Fill(this.Ds);
            }
            catch (Exception ex)
            {
                ExcHandling(ex.Message);
            }
            return Ds;

        }

        public void ExcHandling(string message)
        {
            MessageBox.Show(message, "⚠️Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DataTable ExecuteQueryTable(string sql)
        {
            this.QueryText(sql);
            this.Sda = new SqlDataAdapter(this.SqlCom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return Ds.Tables[0];
        }

        public int ExecutiveDMLQuery(string sql)
        {
            this.QueryText(sql);
            int aff = this.SqlCom.ExecuteNonQuery();
            return aff;
        }
    }
}
