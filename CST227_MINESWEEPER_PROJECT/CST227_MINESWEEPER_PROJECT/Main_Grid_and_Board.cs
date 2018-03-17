using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST227_MINESWEEPER_PROJECT
{
    public partial class Main_Grid_and_Board : Form
    {
      
        public Main_Grid_and_Board()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_Grid_and_Board_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TO-Do: I need to check if level of the game has been selected before the form redirects to the game board.
            this.Hide();
            Select_Level select_Level = new Select_Level();
            select_Level.Show();




        }
        
       
    }
}
