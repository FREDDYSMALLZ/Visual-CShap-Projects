using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CS_DGVIEW_ADD_UPDATE_DELETE
{
    public partial class Form1 : Form
    {
        static string conString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\FREDDYSMALLZ\Documents\TeamsDB.accdb;
Persist Security Info=False;";
        OleDbConnection con = new OleDbConnection(conString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
            //DATAGRIDVIEW PROPERTIES
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Name";
            dataGridView1.Columns[2].Name = "Position";
            dataGridView1.Columns[3].Name = "Team";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //SELECTION MODE
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }
        //INSERT INTO DB
        private void add(string name, string pos, string team)
        {
            //SQL STMT
            string sql = "INSERT INTO peopleTB(Name,Position,Team) VALUES(Name='"+ nametxt.Text + "',POSITION='" + posTxt.Text + "',TEAM='" + teamtxt.Text + "')";
            cmd = new OleDbCommand(sql, con);

            //ADD PARAMS
            cmd.Parameters.AddWithValue("@PNAME", name);
            cmd.Parameters.AddWithValue("@POSITION", pos);
            cmd.Parameters.AddWithValue("@TEAM", team);
            //OPEN CON AND EXEC insert
            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    clearTxts();
                    MessageBox.Show("Successfully Inserted");
                }
                con.Close();
                retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        //FILL DGVIEW
        private void populate(string id, string name, string pos, string team)
        {
            dataGridView1.Rows.Add(id, name, pos, team);
        }
        //RETRIEVAL OF DATA
        private void retrieve()
        {
            dataGridView1.Rows.Clear();
            //SQL STMT
            String sql = "SELECT * FROM peopleTB ";
            cmd = new OleDbCommand(sql, con);
            try
            {
                con.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);
                //LOOP THRU DT
                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());
                }

                con.Close();
                //CLEAR DT 
                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        //UPDATE DB
        private void update(int id, string name, string pos, string team)
        {
            //SQL STMT
            string sql = "UPDATE peopleTB SET N='" + name + "',P='" + pos + "',T='" + team + "' WHERE ID=" + id + "";
            cmd = new OleDbCommand(sql, con);
            //OPEN CON,UPDATE,RETRIEVE DGVIEW
            try
            {
                con.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.UpdateCommand = con.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;
                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    clearTxts();
                    MessageBox.Show("Successfully Updated");
                }
                con.Close();
                //REFRESH
                retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        //DELETE FROM DB
        private void delete(int id)
        {
            //SQL STMT
            String sql = "DELETE FROM peopleTB WHERE ID=" + id + "";
            cmd = new OleDbCommand(sql, con);
            //'OPEN CON,EXECUTE DELETE,CLOSE CON
            try
            {
                con.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.DeleteCommand = con.CreateCommand();
                adapter.DeleteCommand.CommandText = sql;
                //PROMPT FOR CONFIRMATION
                if (MessageBox.Show("Sure ??", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Successfully deleted");
                    }
                }
                con.Close();
                retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        //CLEAR TXT
        private void clearTxts()
        {
            nametxt.Text = "";
            posTxt.Text = "";
            teamtxt.Text = "";
        }
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            nametxt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            posTxt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            teamtxt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            add(nametxt.Text, posTxt.Text, teamtxt.Text);
        }
        private void retrieveBtn_Click(object sender, EventArgs e)
        {
            retrieve();
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            String selected = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);
            update(id, nametxt.Text, posTxt.Text, teamtxt.Text);
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            String selected = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);
            delete(id);
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            clearTxts();
        }
    }
}