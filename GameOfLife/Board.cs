﻿using System;
using System.Collections;
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
        int sizeX;
        int sizeY;

        Stack<int[]> StackOn = new Stack<int[]>();
        Stack<int[]> StackOff = new Stack<int[]>();

        //initialize the board with a 2d array
        public Board(bool[,] bools) {
            initialize(bools);
            sizeX = bools.GetLength(0);
            sizeY = bools.GetLength(1);
        }

        //when called empty creates a 10x10 board with all cells dead
        public Board()
        {
            initialize(new bool[10,10]);
        }


        public void next()
        {
            foreach(var cell in board)
            {
                if(cell.x == 0 ||  
                   cell.y == 0 || 
                   cell.x == sizeX-1 || 
                   cell.y == sizeY-1 )
                {
                    continue;
                }
                else
                {
                    if (cell.isAlive)
                    {
                        //Todo: underpopulation, overpopulation
                    }
                    else
                    {
                        //Todo: reproduction
                    }
                }
            }
            updateBoard();
        }

        private void updateBoard()
        {
            while (StackOff.Count > 0)
            {
                int[] item = StackOff.Pop();
                findCell(item[0], item[1]).isAlive = false;
            }

            while (StackOn.Count > 0)
            {
                int[] item = StackOn.Pop();
                findCell(item[0], item[1]).isAlive = true;
            }
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
