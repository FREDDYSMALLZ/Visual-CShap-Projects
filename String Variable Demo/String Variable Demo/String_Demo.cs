using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Variable_Demo
{
    public partial class String_Demo : Form
    {
        public String_Demo()
        {
            InitializeComponent();
        }

        private void showNamebtn_Click(object sender, EventArgs e)
        {
            //Declare a string variable to hold the full name
            string fullName;

            //Combine the names with a spsce between the names
            //Assign the results to the full name variable.
            fullName = firstNametextBox.Text + " " + lastNametextBox.Text;

            //Display the full name on the full name textbox
            fullNametextBox.Text = fullName;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
