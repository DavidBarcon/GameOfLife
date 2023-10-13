using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    internal class Board
    {

        List<Cell> board;

        //initialize the board with a 2d array
        public Board(bool[,] bools) {
            initialize(bools);
        }

        //when called empty creates a 10x10 board with all cells dead
        public Board()
        {
            initialize(new bool[10,10]);
        }


        public void initialize(bool[,] bools)
        {
            board = new List<Cell>();

            for (int x = 0; x < bools.GetLength(0); x++)
            {
                for (int y = 0; y < bools.GetLength(1); y++)
                {
                    board.Add(new Cell(bools[x, y], x, y));
                }
            }
        }

        private Cell findCell(int x, int y)
        {
            return board.Find(cell =>
                cell.x == x && cell.y == y
            );
        }

    }
}
