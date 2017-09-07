using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Customer_Database
{
    public partial class CustomerDb : Form
    {
        public CustomerDb()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myCustomerDBDataSet);

        }

        private void CustomerDb_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myCustomerDBDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.myCustomerDBDataSet.Customers);

        }
    }
}
