using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    internal class Cell
    {
        public bool isAlive { get; set; }
        public int x { get; }
        public int y { get; }

        public Cell(bool isAlive, int x, int y ) { 
            this.isAlive = isAlive;
            this.x = x;
            this.y = y; 
        }   

    }
}
