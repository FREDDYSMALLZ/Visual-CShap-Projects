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
        public Simple_Interest()
        {
            InitializeComponent();
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            try
            {
                textBox_AmountBorrowed.Clear();
                textBox_InterestRate.Clear();
                textBox_InterestRate.Clear();
                MessageBox.Show("The field is successfully Cleared.");

            }
            catch (Exception)
            {

                MessageBox.Show("Error in clearing the filed. Please check the selection cursor and then click clear.");
            }
        }

        private void Simple_Interest_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
