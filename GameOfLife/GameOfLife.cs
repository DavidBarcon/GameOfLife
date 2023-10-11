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
        bool[,] board;

        Stack<int[]> StackOn = new Stack<int[]>();
        Stack<int[]> StackOff = new Stack<int[]>();

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
                    if (!board[x, y])
                    {
                        reproduction(x, y);
                    }
                }
            }
            updateBoard();
        }

        //when a pixel is inactive, if there are exactly 3 active adjacent pixels, this is activated
        private void reproduction(int x, int y)
        {
            int numberOfAdjacent = countAdjacent(x, y);
            if (numberOfAdjacent == 3)
            {
                StackOn.Push(new[] { x, y });
            }
        }

        //gets the changes queued in the stacks and adds them to the board
        private void updateBoard()
        {
            while (StackOff.Count > 0)
            {
                int[] item = StackOff.Pop();
                board[item[0], item[1]] = false;
            }

            while (StackOn.Count > 0)
            {
                int[] item = StackOn.Pop();
                board[item[0], item[1]] = true;
            }
        }

        //check the number of adjacent active pixels to a said pixel
        private int countAdjacent(int x, int y)
        {
            int res = 0;

            if (board[x - 1, y + 1]) res++;
            if (board[x - 1, y]) res++;
            if (board[x - 1, y - 1]) res++;
            if (board[x, y + 1]) res++;
            if (board[x, y - 1]) res++;
            if (board[x + 1, y + 1]) res++;
            if (board[x + 1, y]) res++;
            if (board[x + 1, y - 1]) res++;

            return res;
        }

        public bool[,] getBoard()
        {
            return (bool[,])board.Clone();
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

