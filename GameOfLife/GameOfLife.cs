using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GameOfLife
{
    public class GameOfLife
    {
        private Board board;
        public GameOfLife(bool[,] values) {
            this.board = new Board(values);
        }

        public GameOfLife()
        {
            this.board = new Board();
        }

        public void next() {
            board.next();
        }

        public bool Equals(GameOfLife game)
        {
            return game.board.Equals(this.board);
            
        }

    }

    
}

