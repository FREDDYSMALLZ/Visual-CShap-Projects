using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compound_Interest_Calculator
{
    public partial class ComupondInterestCalculator : Form
    {
        public ComupondInterestCalculator()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double principal = string.IsNullOrEmpty(principalTextBox.Text) ? 1 : double.Parse(principalTextBox.Text);
                double annual_Interest_Rate = string.IsNullOrEmpty(annualInterestTextBox.Text) ? 1 : double.Parse(annualInterestTextBox.Text);
                double number_Of_Times = string.IsNullOrEmpty(numberOfTimesTextBox.Text) ? 1 : double.Parse(numberOfTimesTextBox.Text);
                double number_Of_Years = string.IsNullOrEmpty(numberOfYeasrTextBox.Text) ? 1 : double.Parse(numberOfYeasrTextBox.Text);

                if (principal == 0)
                {
                    MessageBox.Show("Inaccurate principal Amount Entered. The Principal Amount cannot be null or zero!!");
                }
                if (annual_Interest_Rate == 0)
                {
                    MessageBox.Show("Inaccurate interest rate entered. Please enter the interest rate as a percentage (%)");
                }
                if (number_Of_Times == 0)
                {
                    MessageBox.Show("Inaccurate number of times entered. Please Enter the number of times that the inerest loan is compounded per year!");
                }
                if (number_Of_Years == 0)
                {
                    MessageBox.Show("Inaccurate value entered. The number of years for the loan to be compounded cannot be null");
                }

                double Rate = annual_Interest_Rate / 100;
                double NUMBER_AND_TIME = number_Of_Times * number_Of_Years;
                double RATE_AND_NUMBER_OF_TIME = Rate / number_Of_Times;
                double Calculation = (1 + RATE_AND_NUMBER_OF_TIME);

                //double COMMPOUND_INTEREST = principal * (1 +(Rate/number_Of_Times) * Math.Pow(number_Of_Times, number_Of_Years)) - principal;
                double COMPOUND_INTEREST = principal * Math.Pow(Calculation, NUMBER_AND_TIME) - principal;
                double AMOUNT = principal + COMPOUND_INTEREST;

                compoundInterestDisplay.Text = string.Format("Your Compound Interst (CI) is: {0:C}.", COMPOUND_INTEREST);
                totalCompoundedInterestDisp.Text = string.Format("Your Total amount accrured for {0:C} Loan borrowed/invested at the rate of " +
                    "{1}% and taking {2} years compounded at {3} months is {4:C}: .", principal, annual_Interest_Rate, number_Of_Years, number_Of_Times, AMOUNT);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            principalTextBox.Clear();
            principalTextBox.Focus();
            annualInterestTextBox.Clear();
            numberOfTimesTextBox.Clear();
            numberOfYeasrTextBox.Clear();
            compoundInterestDisplay.Text = "";
            totalCompoundedInterestDisp.Text = "";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
