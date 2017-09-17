using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Login : Form
    {
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
                //Loads the parent/Home page after the user successfully logs in to the system.
                LibraryManagementSystem libraryManagement = new LibraryManagementSystem();
                libraryManagement.Show();
                this.Hide();


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
