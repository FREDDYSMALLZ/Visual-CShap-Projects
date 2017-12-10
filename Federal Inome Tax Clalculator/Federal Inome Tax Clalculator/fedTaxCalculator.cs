using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Federal_Inome_Tax_Clalculator
{
    public partial class fedTaxCalculator : Form
    {
        public fedTaxCalculator()
        {
            InitializeComponent();
        }

        private void calculateTaxBtn_Click(object sender, EventArgs e)
        {
            double status = Convert.ToDouble(statusTextBox.Text);//Gets input from the  status textbox
            double income = Convert.ToDouble(incomeTextBox.Text);// Gets user input from the income textbox

            string status_Description = string.Empty;

            if (status == 0)
            {
                status_Description = "Compute tax for single filers";
            }
            if (status == 1)
            {
                status_Description = "Compute tax for Married filing jointly or qualifying widow(er)";
            }
            if (status == 2)
            {
                status_Description = "Compute tax for Married filing separately";
            }
            if (status == 3)
            {
                status_Description = "Compute tax for Head of Household";
            }
            else
            {
                status_Description = "Invalid inpute for computing/filing federal tax";
            }
            /*
            double ten_percent = 10 / 100;
            double fifteen_percent = 15 / 100;
            double twenty_five_percent = 25 / 100;
            double twenty_eight_percent = 28 / 100;
            double thirty_three_percent = 33 / 100;
            double thirty_five_percent = 35 / 100;
            double thirty_ninesix_percent = 39.6 / 100;  
          */
            double tax = 0;

            if (status == 0)
            { // Compute tax for single filers
                if (income <= 8350)
                    tax = income * 0.10;
                else if (income <= 33950)
                    tax = 8350 * 0.10 + (income - 8350) * 0.15;
                else if (income <= 82250)
                    tax = 8350 * 0.10 + (33950 - 8350) * 0.15 + (income - 33950)
                      * 0.25;
                else if (income <= 171550)
                    tax = 8350 * 0.10 + (33950 - 8350) * 0.15 + (82250 - 33950)
                      * 0.25 + (income - 82250) * 0.28;
                else if (income <= 372950)
                    tax = 8350 * 0.10 + (33950 - 8350) * 0.15 + (82250 - 33950)
                      * 0.25 + (171550 - 82250) * 0.28 + (income - 171550)
                      * 0.33;
                else
                    tax = 8350 * 0.10 + (33950 - 8350) * 0.15 + (82250 - 33950)
                      * 0.25 + (171550 - 82250) * 0.28 + (372950 - 171550)
                      * 0.33 + (income - 372950) * 0.35;
            }
            else if (status == 1)
            { // Compute tax for married file jointly
                if (income <= 16700)
                    tax = income * 0.10;
                else if (income <= 67900)
                    tax = 16700 * 0.10 + (income - 16700) * 0.15;
                else if (income <= 137050)
                    tax = 16700 * 0.10 + (67900 - 16700) * 0.15 + (income - 67900)
                      * 0.25;
                else if (income <= 208850)
                    tax = 16700 * 0.10 + (67900 - 16700) * 0.15 + (137050 - 67900)
                      * 0.25 + (income - 137050) * 0.28;
                else if (income <= 372950)
                    tax = 16700 * 0.10 + (67900 - 16700) * 0.15 + (137050 - 67900)
                      * 0.25 + (208850 - 137050) * 0.28 + (income - 208850)
                      * 0.33;
                else
                    tax = 16700 * 0.10 + (67900 - 16700) * 0.15 + (137050 - 67900)
                      * 0.25 + (208850 - 137050) * 0.28 + (372950 - 208850)
                      * 0.33 + (income - 372950) * 0.35;
            }
            else if (status == 2)
            { // Compute tax for married separately
                if (income <= 8350)
                    tax = income * 0.10;
                else if (income <= 33950)
                    tax = 8350 * 0.10 + (income - 8350) * 0.15;
                else if (income <= 68525)
                    tax = 8350 * 0.10 + (33950 - 8350) * 0.15 + (income - 33950)
                      * 0.25;
                else if (income <= 104425)
                    tax = 8350 * 0.10 + (33950 - 8350) * 0.15 + (68525 - 33950)
                      * 0.25 + (income - 68525) * 0.28;
                else if (income <= 186475)
                    tax = 8350 * 0.10 + (33950 - 8350) * 0.15 + (68525 - 33950)
                      * 0.25 + (104425 - 68525) * 0.28 + (income - 104425)
                      * 0.33;
                else
                    tax = 8350 * 0.10 + (33950 - 8350) * 0.15 + (68525 - 33950)
                      * 0.25 + (104425 - 68525) * 0.28 + (186475 - 104425)
                      * 0.33 + (income - 186475) * 0.35;
            }
            else if (status == 3)
            { // Compute tax for head of household
                if (income <= 11950)
                    tax = income * 0.10;
                else if (income <= 45500)
                    tax = 11950 * 0.10 + (income - 11950) * 0.15;
                else if (income <= 117450)
                    tax = 11950 * 0.10 + (45500 - 11950) * 0.15 + (income - 45500)
                      * 0.25;
                else if (income <= 190200)
                    tax = 11950 * 0.10 + (45500 - 11950) * 0.15 + (117450 - 45500)
                      * 0.25 + (income - 117450) * 0.28;
                else if (income <= 372950)
                    tax = 11950 * 0.10 + (45500 - 11950) * 0.15 + (117450 - 45500)
                      * 0.25 + (190200 - 117450) * 0.28 + (income - 190200)
                      * 0.33;
                else
                    tax = 11950 * 0.10 + (45500 - 11950) * 0.15 + (117450 - 45500)
                      * 0.25 + (190200 - 117450) * 0.28 + (372950 - 190200)
                      * 0.33 + (income - 372950) * 0.35;
            }
            else
            {
                MessageBox.Show("Invalid Status", "ALERT", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
           
            //Display the output
            incomeTaxDIisplayLBL.Text = string.Format("You entered {0} as your status, {1:C} as your income. Therefore," +
                " your Federal taxable income is {2:C}.",status,income,tax);
            }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            //Claring the fields when new data input nneds to be entered.
            statusTextBox.Clear();
            statusTextBox.Focus();
            incomeTextBox.Clear();
            incomeTaxDIisplayLBL.Text = "";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();//Form closing
        }

        private void incomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

