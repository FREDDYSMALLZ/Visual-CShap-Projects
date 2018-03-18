using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper_Game
{
    class Cell
    {


        public Cell()
        {
        }

        public Cell(int row, int column)
        {
            this.row = row;
            this.column = column;
            neighbors = 0;
            cell_Is_Visited = false;
            cell_Is_Live = false;
        }

        private int row;

        public int Row
        {
            get { return row; }
            set { row = value; }
        }

        private int column;

        public int Column
        {
            get { return column; }
            set { column = value; }
        }
        private int neighbors;

        public int Neighbors
        {
            get { return neighbors; }
            set { neighbors = value; }
        }
        private Boolean cell_Is_Visited;

        public Boolean Cell_Is_Visited
        {
            get { return cell_Is_Visited; }
            set { cell_Is_Visited = value; }
        }
        private Boolean cell_Is_Live;

        public Boolean Cell_Is_Live
        {
            get { return cell_Is_Live; }
            set { cell_Is_Live = value; }
        }




    }
}
