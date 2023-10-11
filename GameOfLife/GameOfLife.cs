using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GameOfLife
{
    public class GameOfLife
    {
        bool[,] board;

        int xDim;
        int yDim;
        public GameOfLife(bool[,] board) {
            this.board = board;
            xDim = board.GetLength(0);
            yDim = board.GetLength(1);
        }

        public void next() {
            for (int x = 1; x < board.GetLength(0)-1; x += 1)
            {
                for (int y = 1; y < board.GetLength(1)-1; y += 1)
                {
                    Console.WriteLine($"{board} at {x} {y}");
                }
            }
            
        }

        //ToString override
        public override string ToString()
        {
            string res ="";

            for (int x = 0; x < board.GetLength(0); x += 1)
            {
                for (int y = 0; y < board.GetLength(1); y += 1)
                {
                    res += board[x, y] + " ";
                }
                res += "\n";
            }
            return res;
        }

        //Tostring , but true is o and false is x
        public string toStringPretty()
        {
            string res = "";

            for (int x = 0; x < board.GetLength(0); x += 1)
            {
                for (int y = 0; y < board.GetLength(1); y += 1)
                {
                    if (board[x, y])
                    {
                        res += "o";
                    }
                    else
                    {
                        res += "x";
                    }
                }
                res += "\n";
            }
            return res;
        }
    }

    
}

