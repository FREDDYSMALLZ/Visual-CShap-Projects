using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class salesCalculator : Form
    {
        public salesCalculator()
        {
            InitializeComponent();
        }

        private void calculateSalePriceButton_Click(object sender, EventArgs e)
        {
            //Variables declarations
            decimal original_price; //Holds the item's original price
            decimal discount_percentage;//Holds the item's original price
            decimal discount_amount;// Holds the amount of discount
            decimal sale_price;//Holds the item's sale price

            //Get the item original price
            original_price = decimal.Parse(originalPriceTextBox.Text);

            //Get the item discount percentage
            discount_percentage = decimal.Parse(percentageDiscountTextBox.Text);
            discount_percentage = (discount_percentage / 100);

            //compute the discount amount
            discount_amount = original_price * discount_percentage;

            //Calculate the sale price
            sale_price = original_price - discount_amount;

            //Display the price to the sales price textbox
            salesPriceTextBox.Text = sale_price.ToString("C");

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //This button closes the entire form 
            this.Close();
        }
    }
}
