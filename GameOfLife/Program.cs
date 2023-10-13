using System.Numerics;

namespace GameOfLife
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool[,] board = new bool[5,5];
            bool[,] values=
            {
                { true, false, true},
                { false, false, false},
                { false, false, true},
            };

            Board board = new Board(values);

            board.next();

            /*GameOfLife gameOfLife = new GameOfLife(board);

            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                Console.WriteLine(gameOfLife.ToString());
                Thread.Sleep(3000);
                gameOfLife.next();

            }*/



        }
    }
}