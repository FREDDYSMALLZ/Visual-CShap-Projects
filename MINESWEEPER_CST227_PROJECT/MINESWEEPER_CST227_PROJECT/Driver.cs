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

        public int Get_User_Input()
        {
            Console.WriteLine("Please enter your board size, between {0} and {1}.", minSize, maxSize);
            int boardsize = Convert.ToInt32(Console.ReadLine());
            return boardsize;
        }

        static void Main(string[] args)
        {
            //int gameBoardSize = 25;
           

            try
            {
                //Invalid
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
