using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINESWEEPER_CST227_PROJECT
{
    class MineSweeperGame : GameBoard, IPlayable
    {
        private Boolean HitMine = false;
        private Boolean GameActive = true;

        //Default Child Class Constructor
        public MineSweeperGame(int gameBoardSize, int minSize, int maxSize) :
            base(gameBoardSize, minSize, maxSize)
        {

        }
        //Implementation of the IPlayable interface
        public void PlayGame()
        {
            while (GameActive)
            {
                //Console.Clear();
                //Display the grid, DisplayGameBoard()

                //Method call to get row, verification inside method
                //Method call to get column, verification inside method

                //Check cell[row, column]live_cell, mark as visited
                //if(cell[row, column]live_cell), set HitMine = true


                if (HitMine)
                {
                    GameActive = false;
                    //break;
                }
            }
            //Other code
        }

        public override void DisplayGameBoard()
        {
            if (HitMine)
                base.DisplayGameBoard();
            else
            {
                for (int i = 0; i < cell.GetLength(0); i++)
                {
                    for (int j = 0; j < cell.GetLength(1); j++)
                    {
                        if (cell[i, j].Neighbor == 0 && cell[i, j].cell_Visited)
                            Console.Write("~ ");
                        else if (cell[i, j].cell_Visited)
                            Console.Write(cell[i, j].Neighbor);
                        else
                            Console.Write("? ");
                    }
                    Console.Write("\n");
                }
            }
        }
    }
}
