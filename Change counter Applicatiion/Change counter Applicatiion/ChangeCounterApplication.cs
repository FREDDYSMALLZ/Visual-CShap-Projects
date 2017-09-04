using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_counter_Applicatiion
{
    public partial class ChangeCounterApplication : Form
    {
        //Constant variables
        const decimal FIVE_CENTS_VALUE = 0.05m;
        const decimal TEN_CENTS_VALUE = 0.10m;
        const decimal TWENTY_FIVE_CENTS_VALUE = 0.25m;
        const decimal FIFTY_CENTS_VALUE = 0.50m;

        //Field variable to hold the total initialized with 0
        private decimal total = 0m;
        public ChangeCounterApplication()
        {
            InitializeComponent();
        }

        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            //Add the value of 5 cents to the total
            total += FIFTY_CENTS_VALUE;

            //Display the total, formatted as currency.
            totalOutputLbl.Text = total.ToString("C");
        }

        private void tenCenysPictureBox_Click(object sender, EventArgs e)
        {
            //Add the value of 10 cents to the total
            total += TEN_CENTS_VALUE;

            //Display the total, formatted as currency.
            totalOutputLbl.Text = total.ToString("C");
        }

        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            //Add the value of 25 cents to the total
            total += TWENTY_FIVE_CENTS_VALUE;

            //Display the total, formatted as currency.
            totalOutputLbl.Text = total.ToString("C");
        }

        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            //Add the value of 50 cents to the total
            total += FIFTY_CENTS_VALUE;

            //Display the total, formatted as currency.
            totalOutputLbl.Text = total.ToString("C");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //Closes the form
            this.Close();
        }
    }
}
