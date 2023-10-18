using System.Numerics;

namespace GameOfLife
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool[,] board = new bool[5,5];
            bool[,] values =
            {
                { false, false, false, false, false},
                { false, false, true, false, false},
                { false, true, true, true, false},
                { false, false, true, false, false},
                { false, false, false, false, false},
            };

            //Board board = new Board(values);

            //board.next();

            GameOfLife gameOfLife = new GameOfLife(values);

            gameOfLife.next();
        }
    }
}