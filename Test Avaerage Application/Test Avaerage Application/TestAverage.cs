using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Avaerage_Application
{
    public partial class TestAverage : Form
    {
        public TestAverage()
        {
            InitializeComponent();
        }

        private void computeAverageBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Declare variables
                double test_1, test_2, test_3;
                double average_Of_testScores;

                //Get the test scores
                test_1 = double.Parse(test1TextBox.Text);
                test_2 = double.Parse(test2TextBox.Text);
                test_3 = double.Parse(test3TextBox.Text);

                //Get the average of the test scores
                average_Of_testScores = (test_1 + test_2 + test_3) / 3.0;

                //Display the output to the avarage output label 
                averageTestScoreLabel.Text = average_Of_testScores.ToString("n1");
            

            }
            catch (Exception ex)
            {
                //Display the error message
                MessageBox.Show(ex.Message);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //Exits the application form
            this.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            //Clears the fields from the application
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageTestScoreLabel.Text = "";

            //Reset the focus to test1
            test1TextBox.Focus();
        }
    }
}
