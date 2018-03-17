using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINESWEEPER_CST227_PROJECT
{
    class GameBoard
    {
        private Cell[,] cell;
        private int gameBoardSize;
        private  int minSize;
        private int maxSize;
        //private Boolean gameBoardStart;
        //private Boolean gameBoardStop;
        private Boolean gameBoardInitialize;

        /*private Boolean gameBoardStart;

        public Boolean Start_GameBoard
        {
            get { return gameBoardStart; }
            
        }
        private Boolean gameBoardStop;

        public Boolean Stop_GameBoard
        {
            get { return gameBoardStop; }
            
        }
        */
        private Boolean boardState;

        public Boolean BoardState
        {
            get { return gameBoardInitialize; }
           
        }



        //Constructor to allocate space for the grid and initialize the board with cells
        public GameBoard(int gameBoardSize, int minSize, int maxSize)
        {
            this.gameBoardSize = gameBoardSize;
            this.minSize = minSize;
            this.maxSize = maxSize;

            //Get the size of the board and determine if it is the right size
            Board_Size(gameBoardSize, maxSize, minSize);

        }
        /*Method to dtermine the Board_Size
         * Test for ivalid board size entries
         */
        private void Board_Size(int gameBoardSize, int maxSize, int minSize)
        {
            if (gameBoardSize <= minSize)
            {
                throw new ApplicationException("Invalid Game Board Size..!!! The board size cannot be less than 0");
            }
            if (gameBoardSize >= maxSize)
            {
                throw new ApplicationException("Ivalid Gameboard size..!!! The game board cannot be greater than the set Maximum size.");
            }
            gameBoardInitialize = true; //Initializes the boad size if the conditions are met
           /*if (gameBoardSize == minSize && gameBoardSize == maxSize)
            {
                gameBoardStart = true;

            }
            if (gameBoardSize != minSize || gameBoardSize != maxSize)
            {
                gameBoardStop = true;

            }
            */
                       
        }
        //Method to Create cells on the gameboard 
        public void Fill_Game_Board()
        {
            for (int i = 0; i < cell.GetLength(0); i++)
            {
                for (int j = 0; j < cell.GetLength(1); j++)
                {
                    Cell gridCell = new Cell(i, j)
                    {
                        live_Cell = Check_Cell_If_Live()
                    };
                    if (gridCell.live_Cell == true)
                    {
                        gridCell.Neighbor = 9;

                        cell[i, j] = gridCell;

                    }
                }
                
            }

            Check_Live_Neighbors();
        }
        //Method to check the number of live neighbors;
        private void Check_Live_Neighbors()
        {
            for (int i = 0; i < cell.GetLength(0); i++)
            {
                for (int j = 0; j < cell.GetLength(1); j++)
                {
                    int x = 0;
                    x += Check_Live_Neighbors(i - 1, j - 1);
                    x += Check_Live_Neighbors(i - 1, j);
                    x += Check_Live_Neighbors(i - 1, j + 1);
                    x += Check_Live_Neighbors(i, j - 1);
                    x += Check_Live_Neighbors(i, j + 1);
                    x += Check_Live_Neighbors(i + 1, j - 1);
                    x += Check_Live_Neighbors(i + 1, j);
                    x += Check_Live_Neighbors(i + 1, j + 1);

                    cell[i, j].Neighbor = x;


                }

            }
        }

        private int Check_Live_Neighbors(int x, int y)
        {
            if (x > -1 && y > -1)
            {
                if (x < this.gameBoardSize && y < this.gameBoardSize)
                {
                    if (cell[x, y].live_Cell == true)
                    {
                        return 1;

                    }

                }
               
            }

            return 0;
        }

        private Random random = new Random();
        private bool Check_Cell_If_Live()
        {
            int x = random.Next(100);
            if (x > 85)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        //Method to display the gameboard
        public void DisplayGameBoard()
        {
            for (int i = 0; i < cell.GetLength(0); i++)
            {
                for (int j = 0; j < cell.GetLength(1); j++)
                {
                    if (cell[i,j].live_Cell)
                    {
                        Console.Write(" * ");

                    }
                    else
                    {
                        Console.Write("{0}", cell[i, j].Neighbor);
                    }

                    Console.Write("\n");

                }

            }
        }
    }
    }

