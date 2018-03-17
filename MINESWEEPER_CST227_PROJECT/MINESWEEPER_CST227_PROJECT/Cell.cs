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
            this.row = row;
            this.column = column;
            neighbor = 0;
            cellVisited = false;
            liveCell = false;
        }

        public Cell(int i, int j)
        {
            this.j = j;
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
        private int j;

        public Boolean live_Cell
        {
            get { return liveCell; }
            set { liveCell = value; }
        }

    }
}
