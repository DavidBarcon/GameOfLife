namespace GameOfLifeTest
{
    [TestClass]
    public class GoLTests
    {

        [TestMethod]
        public void TestReproduction()
        {
            bool[,] board =
            {
                { false, false, false, false},
                { false, false, true, false},
                { false, true, true, false},
                { false, false, false, false},
            };

            bool[,] boardExpected =
            {
                { false, false, false, false},
                { false, true, true, false},
                { false, true, true, false},
                { false, false, false, false},
            };



            GameOfLife.GameOfLife gameOfLife =
                new GameOfLife.GameOfLife(board);
            gameOfLife.next();

            GameOfLife.GameOfLife gameOfLifeExpected =
                new GameOfLife.GameOfLife(boardExpected);

            Assert.IsTrue(gameOfLife.Equals(gameOfLifeExpected));
        }

        [TestMethod]
        public void TestUnderpopulationn()
        {
            bool[,] board =
            {
                { false, false, false},
                { false, true, false},
                { false, false , false},
            };

            bool[,] boardExpected =
            {
                { false, false, false},
                { false, false, false},
                { false, false , false},
            };



            GameOfLife.GameOfLife gameOfLife =
                new GameOfLife.GameOfLife(board);
            gameOfLife.next();

            GameOfLife.GameOfLife gameOfLifeExpected =
                new GameOfLife.GameOfLife(boardExpected);

            Assert.IsTrue(gameOfLife.Equals(gameOfLifeExpected));
        }

        /*[TestMethod]
        public void TestOverpopulationn()
        {
            bool[,] board =
            {
                { false, false, false, false},
                { false, true, true, false},
                { false, true, true, false},
                { false, true, false, false},
                { false, false, false, false},
            };
            GameOfLife.GameOfLife gameOfLife =
                new GameOfLife.GameOfLife(board);
            gameOfLife.next();
            board = gameOfLife.getBoard();

            Assert.IsFalse(board[2, 2]);
        }*/

    }
}