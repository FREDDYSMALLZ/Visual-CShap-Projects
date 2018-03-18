using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MineSweeper_Game
{
	class GameBoard
	{
		private Cell[,] cell;

		private int gameBoardSize;
		private int gameBoard_MinSize;//Sets the minimum board size
		private int gameBoard_MaxSize;//Sets the maximum board size

		public Boolean BoardState { get => gameBoardInitialize; }
		private Boolean gameBoardInitialize;

		public Boolean MyProperty
		{
			get { return gameBoardInitialize; }

		}


		public GameBoard(int gameBoardSize, int gameBoard_MinSize, int gameBoard_MaxSize)
		{
			this.gameBoardSize = gameBoardSize;
			this.gameBoard_MinSize = gameBoard_MinSize;
			this.gameBoard_MaxSize = gameBoard_MaxSize;
			DetermineBoardSize(gameBoardSize, gameBoard_MinSize, gameBoard_MaxSize);
			cell = new Cell[gameBoardSize, gameBoardSize];
		}

		//Method to determine board size
		private void DetermineBoardSize(int boardSize, int minSize, int maxSize)
		{
			if (boardSize <= minSize)
			{
				throw new ApplicationException("Invalid Parameters...!!!, Board size cannot be less than 0.");
			}
			if (boardSize >= maxSize)
			{
				throw new ApplicationException("Invalid Parameter, Board size cannot be greater than the set Size.");
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
					gameCell.Cell_Is_Live = Check_Cell_Is_Live();
					if (gameCell.Cell_Is_Live == true)
						gameCell.Neighbors = 9;
					cell[i, j] = gameCell;
				}
			}
			Check_Live_Neighbor();
		}
		//Private field and method to determine if the Cell is live
		private Random random = new Random();

		public Boolean Check_Cell_Is_Live()
		{
			int x = random.Next(101);
			if (x > 80)
				return true;
			else
				return false;
		}
		//Method to determine number of live neighbors
		private void Check_Live_Neighbor()
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
					if (cell[x, y].Cell_Is_Live == true)
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
					if (cell[i, j].Cell_Is_Live)
						Console.Write("* ");
					else
						Console.Write("{0} ", cell[i, j].Neighbors);
				}
				Console.Write("\n");
			}

		}
	}
}
