using CodeNameLogic.BoardModels;
using CodeNameLogic.CardModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeNameLogicUnitTests
{
    [TestClass]
    public class BoardTests
    {
        private BoardDescriptor CreateBoardDescriptor(int rowsNumber, int colsNumber)
        {
            CardRole[,] roles = new CardRole[rowsNumber, colsNumber];
            return new BoardDescriptor(roles);
        }

        [TestMethod]
        public void Should_CreateBoard_When_NotOversteppingMaxBoundaries()
        {
            BoardDescriptor inBounds = CreateBoardDescriptor(5, 5);
            Board board = new Board(inBounds);
            Assert.IsNotNull(board);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Should_ThrowException_When_OversteppingMaxBoundaries()
        {
            BoardDescriptor inBounds = CreateBoardDescriptor(20, 20);
            Board board = new Board(inBounds);
        }
    }
}
