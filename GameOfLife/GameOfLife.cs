﻿namespace GameOfLife
{
    public class GameOfLife
    {
        private Board board;
        public GameOfLife(bool[,] values) {
            this.board = new Board(values);
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

