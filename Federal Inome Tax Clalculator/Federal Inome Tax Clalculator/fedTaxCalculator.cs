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
            double ten_percent = 10 / 100;
            double fifteen_percent = 15 / 100;
            double twenty_five_percent = 25 / 100;
            double twenty_eight_percent = 28 / 100;
            double thirty_three_percent = 33 / 100;
            double thirty_five_percent = 35 / 100;
            double thirty_ninesix_percent = 39.6 / 100;

            double tax = 0;

            if (status == 0)//Compute taxes for single filers
            {
                if (income <= 9325)
                {
                    tax = income * ten_percent;
                }
                else if (income <= 37950)
                {
                    tax = 9325 * ten_percent + (income - 9325) * fifteen_percent;
                }
                else if (income <= 91900)
                {
                    tax = 9325 * ten_percent + (37950 - 9325) * fifteen_percent + (income - 37950) * twenty_five_percent;
                }
                else if (income <= 191650)
                {
                    tax = 9325 * ten_percent + (37950 - 9325) * fifteen_percent + (91900 - 37950) * twenty_five_percent + (income - 91900) * twenty_eight_percent;
                }
                else if (income <= 416700)
                {
                    tax = 9325 * ten_percent + (37950 - 9325) * fifteen_percent + (91900 - 37950) * twenty_five_percent + (191650 - 91900) * twenty_eight_percent
                        + (income - 191650) * thirty_three_percent;
                }
                else if (income <= 418400)
                {
                    tax = 9325 * ten_percent + (37950 - 9325) * fifteen_percent + (91900 - 37950) * twenty_five_percent + (191650 - 91900) * twenty_eight_percent
                       + (416700 - 191650) * thirty_three_percent + (income - 416700) * thirty_five_percent;
                }
                else
                {
                    tax = 9325 * ten_percent + (37950 - 9325) * fifteen_percent + (91900 - 37950) * twenty_five_percent + (191650 - 91900) * twenty_eight_percent
                      + (416700 - 191650) * thirty_three_percent + (418400 - 416700) * thirty_five_percent + (income - 418400) * thirty_ninesix_percent;
                }
            }
            else if (status == 1) //Compute tax for married file jointly or qualifying widow(er)
            {
                if (income <= 18650)
                {
                    tax = income * ten_percent;
                }
                else if (income <= 75900)
                {
                    tax = 18650 * ten_percent + (income - 18650) * fifteen_percent;
                }
                else if (income <= 153100)
                {
                    tax = 18650 * ten_percent + (75900 - 18650) * fifteen_percent + (income - 75900) * twenty_five_percent;
                }
                else if (income <= 233350)
                {
                    tax = 18650 * ten_percent + (75900 - 18650) * fifteen_percent + (153100 - 75900) * twenty_five_percent + (income - 153100) * twenty_eight_percent;
                }
                else if (income <= 416700)
                {
                    tax = 18650 * ten_percent + (75900 - 18650) * fifteen_percent + (153100 - 75900) * twenty_five_percent + (233350 - 153100) * twenty_eight_percent
                        + (income - 233350) * thirty_three_percent;
                }
                else if (income <= 470700)
                {
                    tax = 18650 * ten_percent + (75900 - 18650) * fifteen_percent + (153100 - 75900) * twenty_five_percent + (233350 - 153100) * twenty_eight_percent
                       + (416700 - 233350) * thirty_three_percent + (income - 416700) * thirty_five_percent;
                }
                else
                {
                    tax = 18650 * ten_percent + (75900 - 18650) * fifteen_percent + (153100 - 75900) * twenty_five_percent + (233350 - 153100) * twenty_eight_percent
                      + (416700 - 233350) * thirty_three_percent + (470700 - 416700) * thirty_five_percent + (income - 470700) * thirty_ninesix_percent;
                }
            }
            else if (status == 2)//compute tax for Married separately
            {
                if (income <= 9325)
                {
                    tax = income * ten_percent;
                }
                else if (income <= 37950)
                {
                    tax = 9325 * ten_percent + (income - 9325) * fifteen_percent;
                }
                else if (income <= 76550)
                {
                    tax = 9325 * ten_percent + (37950 - 9325) * fifteen_percent + (income - 37950) * twenty_five_percent;
                }
                else if (income <= 116675)
                {
                    tax = 9325 * ten_percent + (37950 - 9325) * fifteen_percent + (76550 - 37950) * twenty_five_percent + (income - 76550) * twenty_eight_percent;
                }
                else if (income <= 208350)
                {
                    tax = 9325 * ten_percent + (37950 - 9325) * fifteen_percent + (76550 - 37950) * twenty_five_percent + (116675 - 76550) * twenty_eight_percent
                        + (income - 116675) * thirty_three_percent;
                }
                else if (income <= 235350)
                {
                    tax = 9325 * ten_percent + (37950 - 9325) * fifteen_percent + (76550 - 37950) * twenty_five_percent + (116675 - 76550) * twenty_eight_percent
                       + (208350 - 116675) * thirty_three_percent + (income - 208350) * thirty_five_percent;
                }
                else
                {
                    tax = 9325 * ten_percent + (37950 - 9325) * fifteen_percent + (76550 - 37950) * twenty_five_percent + (116675 - 76550) * twenty_eight_percent
                      + (208350 - 116675) * thirty_three_percent + (235350 - 208350) * thirty_five_percent + (income - 235350) * thirty_ninesix_percent;
                }
            }
            else if (status == 3)
            {
                if (income <= 13350)
                {
                    tax = income * ten_percent;
                }
                else if (income <= 50800)
                {
                    tax = 13350 * ten_percent + (income - 13350) * fifteen_percent;
                }
                else if (income <= 131200)
                {
                    tax = 13350 * ten_percent + (50800 - 13350) * fifteen_percent + (income - 50800) * twenty_five_percent;
                }
                else if (income <= 212500)
                {
                    tax = 13350 * ten_percent + (50800 - 13350) * fifteen_percent + (131200 - 50800) * twenty_five_percent + (income - 131200) * twenty_eight_percent;
                }
                else if (income <= 416700)
                {
                    tax = 13350 * ten_percent + (50800 - 13350) * fifteen_percent + (131200 - 50800) * twenty_five_percent + (212500 - 131200) * twenty_eight_percent
                        + (income - 212500) * thirty_three_percent;
                }
                else if (income <= 444550)
                {
                    tax = 13350 * ten_percent + (50800 - 13350) * fifteen_percent + (131200 - 50800) * twenty_five_percent + (212500 - 131200) * twenty_eight_percent
                       + (416700 - 212500) * thirty_three_percent + (income - 416700) * thirty_five_percent;
                }
                else
                {
                    tax = 13350 * ten_percent + (50800 - 13350) * fifteen_percent + (131200 - 50800) * twenty_five_percent + (212500 - 131200) * twenty_eight_percent
                      + (416700 - 212500) * thirty_three_percent + (444550 - 416700) * thirty_five_percent + (income - 444550) * thirty_ninesix_percent;
                }
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
    }
    }

