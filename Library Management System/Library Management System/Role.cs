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
namespace Library_Management_System
{
    public partial class Role : Form
    {
        public Role()
        {
            InitializeComponent();
        }

        private void roleNewBTN_Click(object sender, EventArgs e)
        {
            Create_New();
        }
        void Create_New()
        {   
            //clears the field after data has been inputted
            //Focus the cursor on the Role Id text box
            role_IdTextBox.Clear();
            roleTextbox.Clear();
            status_RoleComboBox.SelectedIndex = -1;

            Connection connection = new Connection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Proc_New_Role", connection.ActiveConnection());
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            role_IdTextBox.Text = table.Rows[0][0].ToString();
            roleTextbox.Focus();

        }
        void Add_Records()
        {
            Connection con = new Connection();
            SqlCommand command = new SqlCommand(@"INSERT INTO [dbo].[Role_Master]
           ([Role_Id]
           ,[Role]
           ,[Role_Status])
     VALUES
           ('" + role_IdTextBox.Text + "','" + roleTextbox.Text + "','" + status_RoleComboBox.Text + "')", con.ActiveConnection());

            command.ExecuteNonQuery();

        }

        private void role_SaveBTN_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Are you sure you want to save the record?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                Add_Records();
                MessageBox.Show("Records Inserted Successfully...!");
                Create_New();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
