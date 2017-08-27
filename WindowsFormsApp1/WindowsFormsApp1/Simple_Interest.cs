using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Simple_Interest : Form
    {
        private readonly TextBox Principal_Amount;

        public Simple_Interest()
        {
            InitializeComponent();
        }

        private void Simple_Interest_Load(object sender, EventArgs e)
        {
            double Principal_Amount;
            double Interest_Rate;
            double Duration;
            double Interest;
            double Amount;
        }

        private void Calculate_button_Click(object sender, EventArgs e)
        {
            try
            {



                
                //double Interest = Principal_Amount * Interest_RatetextBox * TimeDuration_textBox;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
