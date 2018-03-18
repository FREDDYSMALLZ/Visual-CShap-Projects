using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MineSweeper_Game
{
    class Driver
    {
        static void Main(string[] args)
        {
            int gameBoardSize = 15;
            int minimumSize = 1;
            int maxSize = 50;
            try
            {
                GameBoard game = new GameBoard(gameBoardSize, minimumSize, maxSize);
                if (!game.BoardState)
                {
                    Console.WriteLine("Invalid board state...!! Please change the board size.");
                    return;
                }
                game.PopulateBoard();
                game.DisplayGameBoard();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
    }
}

