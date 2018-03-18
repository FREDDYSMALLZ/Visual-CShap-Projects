using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINESWEEPER_CST227_PROJECT
{
    class Cell
    {
        /*Cell properties*/
        //private int row;
        //private int column;
        //private int neighbor;
        // private Boolean cellVisited;
        //private Boolean liveCell;

       
        // Constructor for the cell class
        public Cell(int row, int column, int neighbor, Boolean cellVisited, Boolean liveCell)
        {
            this.Row = row;
            this.Colm = column;
            this.Neighbor = neighbor;
            this.cell_Visited = cellVisited;
            this.live_Cell = liveCell;
        }
        //Default Constructor
        public Cell(int i, int j)
        {
            this.Row = i;
            this.Colm = j;
            this.Neighbor = 0;
            this.cell_Visited = false;
            this.live_Cell = false;
        }



        //The get and set methods to get the properties of the cell
        private int row;

        public int Row
        {
            get { return row; }
            set { row = value; }
        }
        private int column;

        public int Colm
        {
            get { return column; }
            set { column = value; }
        }
        private int neighbor;

        public int Neighbor
        {
            get { return neighbor; }
            set { neighbor = value; }
        }
        private Boolean cellVisited;

        public Boolean cell_Visited
        {
            get { return cellVisited; }
            set { cellVisited = value; }
        }
        private Boolean liveCell;

        public Boolean live_Cell
        {
            get { return liveCell; }
            set { liveCell = value; }
        }

    }
}
