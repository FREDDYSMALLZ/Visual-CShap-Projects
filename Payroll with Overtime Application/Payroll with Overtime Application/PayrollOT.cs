using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime_Application
{
    public partial class PayrollOT : Form
    {
        //Named constants 
        const decimal BASE_HOURS = 40m;
        const decimal OVERTIME_MULTIPLIER = 1.5m;

        //Declaring local variables
        decimal hoursWorked;//Numner of hours worked
        decimal hourlyPayRate;//Hourly Pay rate
        decimal basePay;//Pay not inclusive of overtime
        decimal overtimeHours;//Overtime hours
        decimal overtimePay;//Overtime pay
        decimal grossPay;// Total gross pay
        public PayrollOT()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Get the hours worked and the pay rate
                hoursWorked = decimal.Parse(hoursWorkedTextBox.Text);
                hourlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text);

                //Determine the gross pay
                if (hoursWorked > BASE_HOURS)
                {
                    //Calculate the base pay
                    basePay = hourlyPayRate * BASE_HOURS;

                    //Calculate the overtime hours
                    overtimeHours = hoursWorked - BASE_HOURS;

                    //Calculate the overtime pay
                    overtimePay = OVERTIME_MULTIPLIER * overtimeHours * hourlyPayRate;

                    //Calculte the gross pay
                    grossPay = overtimePay + basePay;
                }
                else
                {
                    //Calculate the gross pay
                    grossPay = hourlyPayRate * hoursWorked;
                }

                //Display the gross pay
                grossPayLabel.Text = grossPay.ToString("C");

            }
            catch (Exception ex)
            {
                //Dispaly the error Message
                MessageBox.Show(ex.Message);
            }

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            //When clicked the function clears the textboxes
            hoursWorkedTextBox.Text = "";
            hourlyPayRateTextBox.Text = "";
            grossPayLabel.Text = "";

            //Reset the focus
            hoursWorkedTextBox.Focus();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //Closes the application
            this.Close();
        }
    }
}
