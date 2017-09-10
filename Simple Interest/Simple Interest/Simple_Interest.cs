using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Interest
{
    public partial class Simple_Interest : Form
    {
        decimal simpleInterest;
        decimal principal;
        decimal rate;
        decimal time;
        decimal totalAmount;
        public Simple_Interest()
        {
            InitializeComponent();
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            try
            {
                amountBorrowedTextBox.Text = "";
                interestRateTextBox.Text = "";
                loanTimeTextBox.Text = "";
                TotalAmountLBL.Text = "";
                MessageBox.Show("The fields are successfully Cleared.");

                //focus the cursor after clearing the fields
                amountBorrowedTextBox.Focus();

            }
            catch (Exception)
            {

                MessageBox.Show("Error in clearing the filed. Please check the selection cursor and then click clear.");
            }
        }

        private void calculateSIBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Get the principal, time and rate
                principal = decimal.Parse(amountBorrowedTextBox.Text);
                rate = decimal.Parse(interestRateTextBox.Text);
                time = decimal.Parse(loanTimeTextBox.Text);

                simpleInterest = principal * rate * time;
                totalAmount = simpleInterest + principal;

                //Display the results. 
                TotalAmountLBL.Text = totalAmount.ToString("C");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Exits the application
            this.Close();
            //
        }
    }
}
