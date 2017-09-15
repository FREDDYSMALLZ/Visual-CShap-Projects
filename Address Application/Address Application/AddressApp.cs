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

namespace Address_Application
{
    public partial class AddressApp : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-OB9VPCC\SQLEXPRESS;Initial Catalog=AddressDB;Integrated Security=True");
        public AddressApp()
        {
            InitializeComponent();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into AddressTBL values('" + firstNameTextBox.Text + "','"
                    + lastNameTextBox.Text + "', '" + addressTextBox.Text + "','" + cityTextBox.Text + "', '"
                    + stateTextBox.Text + "', '" + zipTextBox.Text + "')";
                command.ExecuteNonQuery();
                connection.Close();
                disp_Data();

                MessageBox.Show("The record has been Inserted Successfully. ");
            }
            catch (Exception)
            {

                MessageBox.Show("Error in Inserting the record. Please check your data entry or connection. ");
            }

        }
        public void disp_Data()
        {
                try
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "select * from AddressTBL";
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;
                    command.ExecuteNonQuery();
                    connection.Close();


                }
                catch (Exception)
                {

                    MessageBox.Show("Error in Display the record. Please check your data entry or connection. ");
                }

            }

        private void AddressApp_Load(object sender, EventArgs e)
        {
            disp_Data();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into AddressTBL values('" + firstNameTextBox.Text + "','"
                    + lastNameTextBox.Text + "', '" + addressTextBox.Text + "','" + cityTextBox.Text + "', '"
                    + stateTextBox.Text + "', '" + zipTextBox.Text + "')";
                command.ExecuteNonQuery();
                connection.Close();
                disp_Data();

                MessageBox.Show("The record has been Inserted Successfully. ");
            }
            catch (Exception)
            {

                MessageBox.Show("Error in Inserting the record. Please check your data entry or connection. ");
            }
        }
    }
    
}
