using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINESWEEPER_CST227_PROJECT
{
    class Driver
    {
        static void Main(string[] args)
        {
            int gameBoardSize = 25;
            int minSize = 1;
            int maxSize = 50;

            try
            {
                GameBoard gameBoard = new GameBoard(gameBoardSize, minSize, maxSize);

                if (!gameBoard.BoardState)
                {
                    Console.WriteLine("Inavlid board state. Please Check on the Board size.");

                    return;

                }
                gameBoard.Fill_Game_Board();
                gameBoard.DisplayGameBoard();
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
