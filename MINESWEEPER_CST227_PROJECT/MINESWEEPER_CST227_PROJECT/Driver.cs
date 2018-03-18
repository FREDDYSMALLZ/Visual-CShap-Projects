using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINESWEEPER_CST227_PROJECT
{
    class Driver
    {
        private int minSize = 0;
        private int maxSize = 50;
        //Prompt the user to enter the row and column
            public int Get_User_Input()
            {
                Console.WriteLine("Please enter your board size, between {0} and {1}.", minSize, maxSize);
                int gameBoard = Convert.ToInt32(Console.ReadLine()); 
                return gameBoard;
            }
    
        static void Main(string[] args)
        {
  
            try
            {
                
                //GameBoard gameBoard = new GameBoard(gameBoardSize, minSize, maxSize);

                Driver test = new Driver();

                MineSweeperGame gameBoard = new MineSweeperGame(test.Get_User_Input(), test.minSize, test.maxSize);

                if (!gameBoard.BoardState)
                {
                    Console.WriteLine("Inavlid board state. Please Check on the Board size.");

                    return;

                }
                gameBoard.Fill_Game_Board();
                gameBoard.PlayGame();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Press Enter to Exit.");

            Console.ReadLine();
        }
    }
}
