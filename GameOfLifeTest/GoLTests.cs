namespace GameOfLifeTest
{
    [TestClass]
    public class GoLTests
    {
        [TestMethod]
        public void TestConstructor()
        {
            bool[,] board  = new bool[3,3];
            GameOfLife.GameOfLife gameOfLife =
                new GameOfLife.GameOfLife(board);

            Assert.AreEqual("False False False \n" +
                            "False False False \n" +
                            "False False False \n",
                            gameOfLife.ToString());
        }

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
            GameOfLife.GameOfLife gameOfLife =
                new GameOfLife.GameOfLife(board);
            gameOfLife.next();
            board = gameOfLife.getBoard();

            Assert.IsTrue(board[1,1]);
        }

        [TestMethod]
        public void TestUnderpopulationn()
        {
            bool[,] board =
            {
                { false, false, false, false},
                { false, true, false, false},
                { false, false, false, false},
                { false, false, false, false},
            };
            GameOfLife.GameOfLife gameOfLife =
                new GameOfLife.GameOfLife(board);
            gameOfLife.next();
            board = gameOfLife.getBoard();

            Assert.IsFalse(board[1, 1]);
        }

        [TestMethod]
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
        }

    }
}