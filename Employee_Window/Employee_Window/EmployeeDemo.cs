using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Window
{
    public partial class EmployeeDemo : Form
    {
        public EmployeeDemo()
        {
            InitializeComponent();
        }

        private void employeeTBLBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeTBLBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeeDataSet);

        }

        private void EmployeeDemo_Load(object sender, EventArgs e)
        {
            this.employeeTBLTableAdapter.Fill(this.employeeDataSet.EmployeeTBL);

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                this.Validate();
                MessageBox.Show("Are you sure you want add new employee data? Click Ok to continue.");
                this.employeeTBLBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.employeeDataSet);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
