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
    public partial class Section : Form
    {
        public Section()
        {
            InitializeComponent();
        }

        private void roleTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sectionNewBTN_Click(object sender, EventArgs e)
        {
            Create_New();
            view_and_Display_Gridview();
        }

        private void section_UpdateBTN_Click(object sender, EventArgs e)
        {
            UpdateRecord();
            view_and_Display_Gridview();
        }

        private void section_DeleteBTN_Click(object sender, EventArgs e)
        {
            Delete_Record();
            view_and_Display_Gridview();
        }

        private void section_SaveBTN_Click(object sender, EventArgs e)
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

        private void Section_Load(object sender, EventArgs e)
        {
            view_and_Display_Gridview();
        }
        void view_and_Display_Gridview()
        {
            Connection connection = new Connection();
            SqlDataAdapter sqlData = new SqlDataAdapter("Select * From Section_Master", connection.ActiveConnection());
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);
            section_dataGridView.Rows.Clear();

            foreach (DataRow item in dataTable.Rows)
            {
                int n = section_dataGridView.Rows.Add();
                section_dataGridView.Rows[n].Cells[0].Value = (n + 1).ToString();
                section_dataGridView.Rows[n].Cells[1].Value = item["Sec_Id"].ToString();
                section_dataGridView.Rows[n].Cells[2].Value = item["Sec_Name"].ToString();
                section_dataGridView.Rows[n].Cells[3].Value = item["Sec_Status"].ToString();

            }
            //rowsCountLBL.Text = "Rows Count:" + dataTable.Rows.Count.ToString();
            sectionRows_Count_OutputLBL.Text = dataTable.Rows.Count.ToString();
        }
        void Create_New()
        {
            //clears the field after data has been inputted
            //Focus the cursor on the Role Id text box
            section_IdTextBox.Clear();
            sectionNameTextbox.Clear();
            status_SectionComboBox.SelectedIndex = -1;

            Connection connection = new Connection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Proc_New_Section", connection.ActiveConnection());
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            section_IdTextBox.Text = table.Rows[0][0].ToString();
            sectionNameTextbox.Focus();

        }
        void Add_Records()
        {
            Connection con = new Connection();
            SqlCommand command = new SqlCommand(@"INSERT INTO [dbo].[Section_Master]
           ([Sec_Id]
           ,[Sec_Name]
           ,[Sec_Status])
     VALUES
           ('" + section_IdTextBox.Text + "','" + sectionNameTextbox.Text + "','" + status_SectionComboBox.Text + "')", con.ActiveConnection());

            command.ExecuteNonQuery();

        }
        void Delete_Record()
        {
            try
            {
                Connection con = new Connection();
                SqlCommand command = new SqlCommand(@"DELETE FROM [dbo].[Section_Master] WHERE [Sec_Id] = '" + section_IdTextBox.Text + "'", con.ActiveConnection());
                if (MessageBox.Show("Are Sure you want to delete the record ??", "DELETE RECORD", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show(" Record Successfully deleted");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            //command.ExecuteNonQuery();

        }
        void UpdateRecord()
        {
            Connection con = new Connection();
            SqlCommand command = new SqlCommand(@"UPDATE [dbo].[Section_Master]
   SET [Sec_Id] = '" + section_IdTextBox.Text + "',[Sec_Name] = '" + sectionNameTextbox.Text +
   "',[Sec_Status] = '" + status_SectionComboBox.Text + "'WHERE [Sec_Id] = '" +
   section_IdTextBox.Text + "'", con.ActiveConnection());
            command.ExecuteNonQuery();

        }

        private void section_dataGridView_MouseClick(object sender, MouseEventArgs e)
        {

            int n = section_dataGridView.SelectedRows[0].Index;
            section_IdTextBox.Text = section_dataGridView.Rows[n].Cells[1].Value.ToString();
            sectionNameTextbox.Text = section_dataGridView.Rows[n].Cells[2].Value.ToString();
            status_SectionComboBox.Text = section_dataGridView.Rows[n].Cells[3].Value.ToString();
        }
    }

}
