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
            view_and_Display_Gridview();
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
                view_and_Display_Gridview();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void Role_Load(object sender, EventArgs e)
        {
            //Create_New();
            view_and_Display_Gridview();

        }
        void view_and_Display_Gridview()
        {
            Connection connection = new Connection();
            SqlDataAdapter sqlData = new SqlDataAdapter("Select * From Role_Master",connection.ActiveConnection());
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);
            role_dataGridView.Rows.Clear();

            foreach (DataRow item in dataTable.Rows)
            {
                int n = role_dataGridView.Rows.Add();
                role_dataGridView.Rows[n].Cells[0].Value = (n + 1).ToString();
                role_dataGridView.Rows[n].Cells[1].Value = item["Role_Id"].ToString();
                role_dataGridView.Rows[n].Cells[2].Value = item["Role"].ToString();
                role_dataGridView.Rows[n].Cells[3].Value = item["Role_Status"].ToString();
                
            }
            //rowsCountLBL.Text = "Rows Count:" + dataTable.Rows.Count.ToString();
            rows_Count_OutputLBL.Text = dataTable.Rows.Count.ToString();
        }

        private void role_dataGridView_MouseClick(object sender, MouseEventArgs e)//Displays the entire row content to respective rows and columns
        {
            int n = role_dataGridView.SelectedRows[0].Index;
            role_IdTextBox.Text = role_dataGridView.Rows[n].Cells[1].Value.ToString();
            roleTextbox.Text = role_dataGridView.Rows[n].Cells[2].Value.ToString();
            status_RoleComboBox.Text = role_dataGridView.Rows[n].Cells[3].Value.ToString();
        }

        private void role_UpdateBTN_Click(object sender, EventArgs e)
        {
            UpdateRecord();
            view_and_Display_Gridview();
        }
        void UpdateRecord()
        {
            Connection con = new Connection();
            SqlCommand command = new SqlCommand(@"UPDATE [dbo].[Role_Master]
   SET [Role_Id] = '" + role_IdTextBox.Text + "',[Role] = '" + roleTextbox.Text +
   "',[Role_Status] = '" + status_RoleComboBox.Text + "'WHERE [Role_Id] = '" +
   role_IdTextBox.Text + "'",con.ActiveConnection());
            command.ExecuteNonQuery();

        }

        private void role_DeleteBTN_Click(object sender, EventArgs e)
        {
            Delete_Record();
            view_and_Display_Gridview();

        }
        void Delete_Record()
        {
            try
            {
                Connection con = new Connection();
                SqlCommand command = new SqlCommand(@"DELETE FROM [dbo].[Role_Master] WHERE [Role_Id] = '" + role_IdTextBox.Text + "'", con.ActiveConnection());
                if (MessageBox.Show("Are Sure you want to delete the record ??", "DELETE RECORD", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show(" Record Successfully deleted");
                    }
                }
               // command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

    }
}
