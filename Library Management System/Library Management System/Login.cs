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
    public partial class Login : Form
    {
        //Connects to the Database where the username and Password is stored
        //SqlConnection connection = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=LMSdatabase;Integrated Security=True");//Connection String
        public Login()
        {
            InitializeComponent();
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            //Closing the entire project 
            this.Close();
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            try
            {
                Connection connection = new Connection();
                 SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From Profile_Master Where Pro_User_Id= '"
                    + usernameTextBox.Text + "' and Pro_Password= '" 
                    + passwordTextBox.Text + "' ", connection.ActiveConnection());

                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count == 1)
                {
                    //Loads the parent/Home page after the user successfully logs in to the system.
                    LibraryManagementSystem libraryManagement = new LibraryManagementSystem();
                    libraryManagement.Show();
                    MessageBox.Show("Please Click Ok. Button to Continue.", "Welcome to Library Management System.", MessageBoxButtons.OK);
                    //MessageBox.Show("Welcome to Library Management System.", "Please Click Ok. Button to Continue.", MessageBoxButtons.OK );
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username/Password!. Please Try again.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
