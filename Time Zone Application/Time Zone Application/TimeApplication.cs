using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Zone_Application
{
    public partial class TimeApplication : Form
    {
        public TimeApplication()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String city; //Holds the name of a city 

            if (citylistBox.SelectedIndex != -1)
            {
                //Get the selected items
                city = citylistBox.SelectedItem.ToString();

                //Declare the time zone

                switch (city)
                {
                    case "Honolulu":
                        display_Time_ZoneLBL.Text = "Hawai-Aleutian";
                        break;
                    case "Denver":
                        display_Time_ZoneLBL.Text = "Mountain";
                        break;
                    case "Minneapolis":
                        display_Time_ZoneLBL.Text = "Central";
                        break;
                    case "New York":
                        display_Time_ZoneLBL.Text = "Eastern";
                        break;
                    case "San Fransisco":
                        display_Time_ZoneLBL.Text = "Paciic";
                        break;

                    case "Arlington":
                        display_Time_ZoneLBL.Text = "Central";
                        break;
                    case "Grand Prairie":
                        display_Time_ZoneLBL.Text = "Central";
                        break;
                    case "Knoxville":
                        display_Time_ZoneLBL.Text = "Central";
                        break;
                    case "Fortworth":
                        display_Time_ZoneLBL.Text = "Central";
                        break;
                    case "Alabama":
                        display_Time_ZoneLBL.Text = "Central";
                        break;
                    case "Mason City":
                        display_Time_ZoneLBL.Text = "Central";
                        break;
                    case "Phoenix":
                        display_Time_ZoneLBL.Text = "Mountain";
                        break;
                    case "Sweet Waters":
                        display_Time_ZoneLBL.Text = "Central";
                        break;
                    case "Salt Lake City":
                        display_Time_ZoneLBL.Text = "Mountain";
                        break;
                    case "Mansfield":
                        display_Time_ZoneLBL.Text = "Central";
                        break;

                }
                
            }
            else
            {
                //No city was Selected
                MessageBox.Show("Select a city.");
            }
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the entire form
            this.Close();
        }
    }
}
