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
    public partial class Select_Level : Form
    {
        int gameBoardSize = 25;
        int minimumSize = 1;
        int maxSize = 50;
        public Select_Level()
        {
            InitializeComponent();
        }

        private void bttn_StartGame_Click(object sender, EventArgs e)
        {
            //TO-Do: Game functions to be included here including the Grid board to display the cells
        }

        private void bttn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Select_Level_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void rd_Bttn_Easy_CheckedChanged(object sender, EventArgs e)
        {
            int diff = 1;
            Select_Level.startGame(diff);
            this.Close();

        }


        //Unimplemented method to start off the game 
        //TO:DO- Need to implement this method so that the user can select the level of play and then start playing the game
        private static void startGame(int diff)
        {
            NewMethod();
        }

        private static void NewMethod()
        {
            GameBoard gameBoard = NewMethod1();
            gameBoard.PopulateBoard();
            gameBoard.DisplayGameBoard();
        }

        private static GameBoard NewMethod1()
        {
            return new GameBoard(gameBoardSize: gameBoardSize, minimumSize: minimumSize, maxSize: maxSize);
        }

        private void rdBttn_Moderate_CheckedChanged(object sender, EventArgs e)
        {
            int diff = 2;
            Select_Level.startGame(diff);
            this.Close();

        }

        private void rdBttn_Difficult_CheckedChanged(object sender, EventArgs e)
        {
            int diff = 3;

            Select_Level.startGame(diff);
            this.Close();

        }
    }
}
