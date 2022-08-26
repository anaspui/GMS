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
    public partial class Employees : UserControl
    {

        private DataAccess da { get; set; }
        private DataSet ds { get; set; }
        private Panel PnlMain;
        public Employees()
        {
            InitializeComponent();
            
        }
        public Employees(Panel PnlMain)
        {
            InitializeComponent();
            da = new DataAccess();
            ds = new DataSet();
            this.PnlMain = PnlMain;
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
        }

        private void btnEmpList_Click(object sender, EventArgs e)
        {

            EmployeeList employeeList = new EmployeeList();
            PnlMain.Controls.Add(employeeList);
            PnlMain.Controls.Remove(this);
            employeeList.Show();
            Hide();

        }
    }
}
