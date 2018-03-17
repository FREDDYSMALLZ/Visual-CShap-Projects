using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST227_MINESWEEPER_PROJECT
{
    class GameBoard
    {
        private Cell[,] cell;
        private Boolean gameBoardInitialize;
        private int gameBoardSize;
        private int minimumSize;
        private int maximumSize;

        public Boolean BoardState { get => gameBoardInitialize; }

        public GameBoard(int gameBoardSize, int minimumSize, int maxSize)
        {
            this.gameBoardSize = gameBoardSize;
            this.minimumSize = minimumSize;
            this.maximumSize = maxSize;
            DetermineBoardSize(gameBoardSize, minimumSize, maxSize);
            cell = new Cell[gameBoardSize, gameBoardSize];
        }

        //Method to determine board size
        private void DetermineBoardSize(int boardSize, int minSize, int maxSize)
        {
            if (boardSize <= minSize)
            {
                throw new ApplicationException("invalid parameter, board size cannot be less than 0.");
            }
            if (boardSize >= maxSize)
            {
                throw new ApplicationException("invalid parameter, board size cannot be greater than max size.");
            }
            gameBoardInitialize = true;
        }
        //Method to create each Cell and fill the gameBoard
        public void PopulateBoard()
        {
            for (int i = 0; i < cell.GetLength(0); i++)
            {
                for (int j = 0; j < cell.GetLength(1); j++)
                {
                    Cell gameCell = new Cell(i, j);
                    gameCell.IsLive = DetermineIsLive();
                    if (gameCell.IsLive == true)
                        gameCell.Neighbors = 9;
                    cell[i, j] = gameCell;
                }
            }
            DetermineLiveNeighbors();
        }
        //Private field and method to determine if the Cell is live
        private Random random = new Random();
       

        public Boolean DetermineIsLive()
        {
            int x = random.Next(101);
            if (x > 80)
                return true;
            else
                return false;
        }
        //Method to determine number of live neighbors
        private void DetermineLiveNeighbors()
        {
            for (int i = 0; i < cell.GetLength(0); i++)
            {
                for (int j = 0; j < cell.GetLength(1); j++)
                {
                    int x = 0;

                    x += CheckNeighbors(i - 1, j - 1);
                    x += CheckNeighbors(i - 1, j);
                    x += CheckNeighbors(i - 1, j + 1);
                    x += CheckNeighbors(i, j - 1);
                    x += CheckNeighbors(i, j + 1);
                    x += CheckNeighbors(i + 1, j - 1);
                    x += CheckNeighbors(i + 1, j);
                    x += CheckNeighbors(i + 1, j + 1);

                    cell[i, j].Neighbors = x;
                }
            }
        }
        private int CheckNeighbors(int x, int y)
        {
            if (x > -1 && y > -1)
            {
                if (x < this.gameBoardSize && y < this.gameBoardSize)
                {
                    if (cell[x, y].IsLive == true)
                        return 1;
                }
            }
            return 0;
        }
        //Method to print maze to console
        public void DisplayGameBoard()
        {
            for (int i = 0; i < cell.GetLength(0); i++)
            {
                for (int j = 0; j < cell.GetLength(1); j++)
                {
                    if (cell[i, j].IsLive)
                        Console.Write("* ");
                    else
                        Console.Write("{0} ", cell[i, j].Neighbors);
                }
                Console.Write("\n");
            }

        }
    }
}

