using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessMineField.Test
{
    [TestClass]
    public class ChessMineFieldPresenterTest
    {
        [TestMethod]
        public void TestMoveLeft() //Test if on navigating to left that the position X gets updated correctly
        {
            ChessMineFieldPresenter presenter = new ChessMineFieldPresenter();
            GameStatus status = presenter.MoveIfPossible(System.ConsoleKey.LeftArrow, 1, 1, 3);
            Assert.AreEqual(status.PosX, 0);
        }

        [TestMethod]
        public void TestMoveUp() //Test if on navigating to up that the position Y gets updated correctly
        {
            ChessMineFieldPresenter presenter = new ChessMineFieldPresenter();
            GameStatus status = presenter.MoveIfPossible(System.ConsoleKey.UpArrow, 1, 1, 3);
            Assert.AreEqual(status.PosY, 0);
        }

        [TestMethod]
        public void TestMoveRight() //Test if on navigating to right that the position X gets updated correctly
        {
            ChessMineFieldPresenter presenter = new ChessMineFieldPresenter();
            GameStatus status = presenter.MoveIfPossible(System.ConsoleKey.RightArrow, 1, 1, 3);
            Assert.AreEqual(status.PosX, 2);
        }

        [TestMethod]
        public void TestMoveDown() //Test if on navigating to down that the position Y gets updated correctly
        {
            ChessMineFieldPresenter presenter = new ChessMineFieldPresenter();
            GameStatus status = presenter.MoveIfPossible(System.ConsoleKey.DownArrow, 1, 1, 3);
            Assert.AreEqual(status.PosY, 2);
        }

        [TestMethod]
        public void TestOngoing() //Test if ongoing is invoked correctly
        {
            ChessMineFieldPresenter presenter = new ChessMineFieldPresenter();
            GameStatus status = presenter.MoveIfPossible(System.ConsoleKey.DownArrow, 1, 1, 3);
            Assert.AreEqual(status.Status, ChessMineFieldConstants.GAME_ONGOING);
        }

        [TestMethod]
        public void TestInvalidMove() //Test if invalid move is invoked correctly
        {
            ChessMineFieldPresenter presenter = new ChessMineFieldPresenter();
            GameStatus status = presenter.MoveIfPossible(System.ConsoleKey.LeftArrow, 0, 1, 3);
            Assert.AreEqual(status.Status, ChessMineFieldConstants.GAME_INVALID_MOVE);
        }

        [TestMethod]
        public void TestWon() //Test if won is invoked correctly
        {
            ChessMineFieldPresenter presenter = new ChessMineFieldPresenter();
            GameStatus status = presenter.MoveIfPossible(System.ConsoleKey.DownArrow, 0, 7, 3);
            Assert.AreEqual(status.Status, ChessMineFieldConstants.GAME_WON);
        }

        [TestMethod]
        public void TestLost() //Test if lost is invoked correctly
        {
            ChessMineFieldPresenter presenter = new ChessMineFieldPresenter();
            GameStatus status = presenter.MoveIfPossible(System.ConsoleKey.RightArrow, 2, 7, 1);
            Assert.AreEqual(status.Status, ChessMineFieldConstants.GAME_LOST);
        }

        [TestMethod]
        public void TestMine1() //Test if mine 1 is deducting life
        {
            ChessMineFieldPresenter presenter = new ChessMineFieldPresenter();
            GameStatus status = presenter.MoveIfPossible(System.ConsoleKey.RightArrow, 1, 0, 3);
            Assert.AreEqual(status.Lives, 2);
        }

        [TestMethod]
        public void TestMine2() //Test if mine 2 is deducting life
        {
            ChessMineFieldPresenter presenter = new ChessMineFieldPresenter();
            GameStatus status = presenter.MoveIfPossible(System.ConsoleKey.RightArrow, 3, 1, 3);
            Assert.AreEqual(status.Lives, 2);
        }

        [TestMethod]
        public void TestMine3() //Test if mine 3 is deducting life
        {
            ChessMineFieldPresenter presenter = new ChessMineFieldPresenter();
            GameStatus status = presenter.MoveIfPossible(System.ConsoleKey.DownArrow, 0, 1, 3);
            Assert.AreEqual(status.Lives, 2);
        }

        [TestMethod]
        public void TestMine4() //Test if mine 4 is deducting life
        {
            ChessMineFieldPresenter presenter = new ChessMineFieldPresenter();
            GameStatus status = presenter.MoveIfPossible(System.ConsoleKey.RightArrow, 2, 3, 3);
            Assert.AreEqual(status.Lives, 2);
        }

        [TestMethod]
        public void TestMine5() //Test if mine 5 is deducting life
        {
            ChessMineFieldPresenter presenter = new ChessMineFieldPresenter();
            GameStatus status = presenter.MoveIfPossible(System.ConsoleKey.RightArrow, 0, 4, 3);
            Assert.AreEqual(status.Lives, 2);
        }

        [TestMethod]
        public void TestMine6() //Test if mine 6 is deducting life
        {
            ChessMineFieldPresenter presenter = new ChessMineFieldPresenter();
            GameStatus status = presenter.MoveIfPossible(System.ConsoleKey.RightArrow, 6, 5, 3);
            Assert.AreEqual(status.Lives, 2);
        }

        [TestMethod]
        public void TestMine7() //Test if mine 7 is deducting life
        {
            ChessMineFieldPresenter presenter = new ChessMineFieldPresenter();
            GameStatus status = presenter.MoveIfPossible(System.ConsoleKey.RightArrow, 4, 6, 3);
            Assert.AreEqual(status.Lives, 2);
        }

        [TestMethod]
        public void TestMine8() //Test if mine 8 is deducting life
        {
            ChessMineFieldPresenter presenter = new ChessMineFieldPresenter();
            GameStatus status = presenter.MoveIfPossible(System.ConsoleKey.RightArrow, 2, 7, 3);
            Assert.AreEqual(status.Lives, 2);
        }
    }
}
