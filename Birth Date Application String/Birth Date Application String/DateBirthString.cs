using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birth_Date_Application_String
{
    public partial class DateBirthString : Form
    {
        public DateBirthString()
        {
            InitializeComponent();
        }

        private void showDateBtn_Click(object sender, EventArgs e)
        {
            //Declare a string variable 
            string output;

            //Concancate the input and build the output string.
            output = dayOfWeekTextBox.Text + ","
                + monthTextBox.Text + "" 
                + dayOfMonthTextBox.Text + "," 
                + yeartextBox.Text + "";
            //Display the output string in the output label control
            dateOutPutLabel.Text = output;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            //When clicked, it clears all the textboxes
            dayOfWeekTextBox.Text = "";
            monthTextBox.Text = "";
            dayOfMonthTextBox.Text = "";
            yeartextBox.Text = "";

            //Also when clicked, it clears the output label control
            dateOutPutLabel.Text = "";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //This button closes the form
            this.Close();
        }
    }
}
