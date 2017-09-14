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

namespace Admin_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-OB9VPCC\SQLEXPRESS;Initial Catalog=Data;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From LOG_IN Where  Username= '" + textBox1.Text + "' and Password= '" + textBox2.Text + "'",connection);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);

            if (dataTable.Rows [0][0].ToString() == "1")
            {
                this.Hide();
                Main ss = new Main();
                ss.Show();


            }
            else
            {
                MessageBox.Show("Please check your Username and Password");    
            }


        }
    }
}
