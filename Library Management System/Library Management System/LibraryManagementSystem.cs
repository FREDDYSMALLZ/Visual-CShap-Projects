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
    public partial class LibraryManagementSystem : Form
    {
        public LibraryManagementSystem()
        {
            InitializeComponent();
        }

        private void LibraryManagementSystem_FormClosed(object sender, FormClosedEventArgs e)
        {
            //This line of code makes the entire application to close.
            //It overides the form hidden mode from the login screen when the user successfuly logs in and closes the application
            Application.Exit();
        }

        private void roleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Connects the role form to be displayed on the home page
            Role role = new Role();
            role.MdiParent = this;
            role.StartPosition = FormStartPosition.CenterScreen;//Form stsrts at the center for the screen
            role.Show();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Connects the profile form to be displayed on the home page
            Profile_Master profile = new Profile_Master();
            profile.MdiParent = this;
            profile.StartPosition = FormStartPosition.CenterScreen;//Form stsrts at the center for the screen
            profile.Show();
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Member_Master member = new Member_Master();
            member.MdiParent = this;
            member.StartPosition = FormStartPosition.CenterScreen;//Form stsrts at the center for the screen
            member.Show();

        }

        private void planToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plan plan = new Plan();
            plan.MdiParent = this;
            plan.StartPosition = FormStartPosition.CenterScreen;//Form stsrts at the center for the screen
            plan.Show();
        }

        private void rackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rack rack = new Rack();
            rack.MdiParent = this;
            rack.StartPosition = FormStartPosition.CenterScreen;//Form stsrts at the center for the screen
            rack.Show();
        }

        private void sectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Section section = new Section();
            section.MdiParent = this;
            section.StartPosition = FormStartPosition.CenterScreen;//Form stsrts at the center for the screen
            section.Show();
        }

        private void sectionRackMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Section_Rack_Map sectionRack = new Section_Rack_Map();
            sectionRack.MdiParent = this;
            sectionRack.StartPosition = FormStartPosition.CenterScreen;//Form stsrts at the center for the screen
            sectionRack.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Connects the Change Password form to be displayed on the home page
            Change_Password changePassword = new Change_Password();
            changePassword.MdiParent = this;
            changePassword.StartPosition = FormStartPosition.CenterScreen;//Form stsrts at the center for the screen
            changePassword.Show();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();
            purchase.MdiParent = this;
            purchase.StartPosition = FormStartPosition.CenterScreen;//Form stsrts at the center for the screen
            purchase.Show();
        }

        private void bookInRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Book_In_Register bookRegister = new Book_In_Register();
            bookRegister.MdiParent = this;
            bookRegister.StartPosition = FormStartPosition.CenterScreen;//Form stsrts at the center for the screen
            bookRegister.Show();
           
        }

        private void bookOutRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book_Out_Register book_Out_Register = new Book_Out_Register();
            book_Out_Register.MdiParent = this;
            book_Out_Register.StartPosition = FormStartPosition.CenterScreen;//Form stsrts at the center for the screen
            book_Out_Register.Show();
        }
    

        private void mamberTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Member_Transaction member_Transaction = new Member_Transaction();
            member_Transaction.MdiParent = this;
            member_Transaction.StartPosition = FormStartPosition.CenterScreen;//Form stsrts at the center for the screen
            member_Transaction.Show();
        }

    }
        
 }
