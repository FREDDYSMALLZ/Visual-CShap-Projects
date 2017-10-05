using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emperial_Body_Mass_Index_Calculator
{
    public partial class EmperialCalculator : Form
    {
        public EmperialCalculator()
        {
            InitializeComponent();
        }

        private void calculateBMI_btn_Click(object sender, EventArgs e)
        {
            double weight;
            double height_in_inches;
            double TOTAL_HEIGHT;
            double BODY_MASS_INDEX;

            if (double.TryParse(poundsTextBox.Text, out weight))
            {

            }
            if (double.TryParse(inchesTextBox.Text, out height_in_inches))
            {
                //Converts the height entered.
                TOTAL_HEIGHT = height_in_inches * 12;

                BODY_MASS_INDEX = (weight /(Math.Pow(TOTAL_HEIGHT, 2.0))) * 703.0;


                if (BODY_MASS_INDEX < 18.0)
                {
                    MessageBox.Show("The Person is Underweight..");
                }
                else if (BODY_MASS_INDEX < 25.0)
                {
                    MessageBox.Show("The Person has Normal Weight..");
                }
                else if (BODY_MASS_INDEX < 30.0)
                {
                    MessageBox.Show("The Person is Obesse..");
                }
                else
                {
                    MessageBox.Show("Invalid Data Entry", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

                BMI_OutPutLBL.Text = BODY_MASS_INDEX.ToString("n1");

            }

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            poundsTextBox.Focus();
            poundsTextBox.Clear();
            inchesTextBox.Clear();
            BMI_OutPutLBL.Text = "";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
