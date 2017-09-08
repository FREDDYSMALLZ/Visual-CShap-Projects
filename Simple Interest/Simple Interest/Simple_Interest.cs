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

            }
            catch (Exception)
            {

                MessageBox.Show("Error in clearing the filed. Please check the selection cursor and then click clear.");
            }
        }

        private void calculateSIBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
