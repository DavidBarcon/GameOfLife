using System.Numerics;

namespace GameOfLife
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool[,] board = new bool[5,5];
            bool[,] board =
            {
                { false, false, false, false, false, false, false},
                { false, false, false, false, false, false, false},
                { false, false, true, true, true, false, false},
                { false, false, true, false, false, false, false},
                { false, false, false, false, false, false, false},
                { false, false, false, false, false, false, false},
                { false, false, false, false, false, false, false},
            };

            GameOfLife gameOfLife = new GameOfLife(board);
            Console.WriteLine(gameOfLife.ToString());


            
        }
    }
}