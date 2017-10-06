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
            /* double weight;
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
             */
            try
            {
                double weight = Convert.ToDouble(poundsTextBox.Text);
                double height_in_inches = Convert.ToDouble(inchesTextBox.Text);

                if (weight == 0)
                {
                    MessageBox.Show("Inaccurate results. Weight entered is not accurate..");
                }
                if (height_in_inches == 0)
                {
                    MessageBox.Show("Inaccurate results. The inches entered is not correct");
                }

                double TOTAL_HEIGHT = height_in_inches * 12;
                double BMI = (weight / (Math.Pow(TOTAL_HEIGHT, 2.0))) * 703;

                string BMI_description = string.Empty;
                if (BMI < 16.5)
                {
                    BMI_description = "Severely Underweight";
                }
                else if (BMI >= 16.5 && BMI < 18.5)
                {
                    BMI_description = "Underweight";
                }
                else if (BMI >= 18.5 && BMI < 25.0)
                {
                    BMI_description = "Normal";
                }
                else if (BMI >= 25.0 && BMI <= 30.0)
                {
                    BMI_description = "Overweight";
                }
                else if (BMI > 30.0 && BMI <= 35.0)
                {
                    BMI_description = "Obesse";
                }
                else if (BMI > 35.0 && BMI <= 40.0)
                {
                    BMI_description = "Clinically obesse";
                }
                else
                {
                    BMI_description = "Morbidly Obesse";
                }

                BMI_OutPutLBL.Text = string.Format("Your Body Mass Index (BMI) is: {0:F2}. This would be considered {1}.", BMI, BMI_description);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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
