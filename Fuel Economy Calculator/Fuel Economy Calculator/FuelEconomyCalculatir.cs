using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy_Calculator
{
    public partial class FuelEconomyCalculatir : Form
    {
        public FuelEconomyCalculatir()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //This button when clicked, it closes the entire fprm application
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Using the try and catch errors to detect any eerors that may arise in the lines of code
            try
            {
                //Declare variables
                double number_Of_miles;//Holds the number of miles the vehicle was driven
                double number_Of_gas_gallons;//Holds the number of gas gallons used
                double miles_per_gallon;//To hold the miles per gallon 

                //Gets the number of miles driven and assigns it to the the miles driven textbox
                number_Of_miles = double.Parse(milesDrivenTextBox.Text);

                //Gets the number of gallons used and assigns it to number of gallons textbox
                number_Of_gas_gallons = double.Parse(numberOfGallonsTextBox.Text);

                //Calculate/compute the miles per gallon
                miles_per_gallon = (number_Of_miles / number_Of_gas_gallons);

                //Assign the output/result to the vehicle MPG label
                vehicleMPGLabel.Text = miles_per_gallon.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
