using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST227_MINESWEEPER_PROJECT
{
    class Cell
    {
        private int row, column, neighbors;
        private Boolean isVisited, isLive;

        public Cell() { }

        public Cell(int row, int column)
        {
            this.row = row;
            this.column = column;
            neighbors = 0;
            isVisited = false;
            isLive = false;
        }
        //Default accessor and mutator methods
        public int Row
        {
            set { row = value; }
            get { return row; }
        }
        public int Column
        {
            set => column = value;
            get => column;
        }

        public int Neighbors
        {
            set => neighbors = value;
            get => neighbors;
        }
        public Boolean IsVisited
        {
            set => isVisited = value;
            get => isVisited;
        }
        public Boolean IsLive
        {
            set => isLive = value;
            get => isLive;
        }
    }
}
