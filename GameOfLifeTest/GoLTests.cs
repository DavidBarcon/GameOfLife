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




    }
}