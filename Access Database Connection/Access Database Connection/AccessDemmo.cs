using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Access_Database_Connection
{
    public partial class AccessDemmo : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public AccessDemmo()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\FREDDYSMALLZ\Documents\Sales.accdb;
Persist Security Info=False;";
        }

        private void customerTBLBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerTBLBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.salesDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesDataSet.CustomerTBL' table. You can move, or remove it, as needed.
            this.customerTBLTableAdapter.Fill(this.salesDataSet.CustomerTBL);

        }

        private void newBTN_Click(object sender, EventArgs e)
        {
        }
        void clearFields()
        {
            customerIdTextBox.Clear();
            customerNameTextBox.Clear();
            customerAddressTextBox.Clear();
            balanceDueTextBox.Clear();
        }
        void dataConnection()
        {

            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO CustomerTBL (CustomerId, CustomerName, CustomerAddress, BalanceDue) VALUES('" + customerIdTextBox.Text +
                    "','" + customerNameTextBox.Text + "','" +
                    customerAddressTextBox.Text + "','" + balanceDueTextBox.Text + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("Data has been sucessfully saved");
                
                customerIdTextBox.Focus();

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in saving data!" + ex);
            }

        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            dataConnection();
            clearFields();
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                String query = "Update CustomerTBL set CustomerId='" + customerIdTextBox.Text +
                    "', CustomerName='" + customerNameTextBox.Text + "', CustomerAddress='" +
                    customerAddressTextBox.Text + "', BalanceDue='" + balanceDueTextBox.Text + "', WHERE CustomerId=" + customerIdTextBox.Text +
                    "";
                MessageBox.Show(query);
                command.CommandText = query;
                command.ExecuteNonQuery();
                MessageBox.Show("Data has been updtaed  sucessfully...!");

                customerIdTextBox.Focus();

                connection.Close();

            }
            catch (Exception )
            {
                MessageBox.Show("Error in Updating data!");
            }
        }
    }
    
}
