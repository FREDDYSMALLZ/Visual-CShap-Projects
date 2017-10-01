using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mass_and_Weight_Application
{
    public partial class Mass_WeightApplication : Form
    {
        public Mass_WeightApplication()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the form
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double mass;   //Holds the Mass object entered by the user
            double weight; //Hold the weight of the object
         

            //To get the value inputed by the user from the mass text box
            //Converts the text entered by the user to a double.
            //Returns true if it successfully converts the text entered or otherwise fail/error
            //Method also takes two arguments
            if (double.TryParse(mass_textBox.Text, out mass))
            {
                //Calculate the weight
                weight = mass * 9.8;

                //Display the weight
                weightOutputLBL.Text = weight.ToString("n1");//rounded to one decimal place

                //Determine if the object is too heavy
                if (weight > 1000)
                {
                    MessageBox.Show("The Object is too heavy!");
                }
                //Determine if the object is too light
                if (weight < 10)
                {
                    MessageBox.Show("The Object is too light!");
                }


            }
            else
            {
                MessageBox.Show("Invalid data entry", "ALERT",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);   
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            mass_textBox.Clear();
            weightOutputLBL.Text = "";
            mass_textBox.Focus();
        }
    }
}
