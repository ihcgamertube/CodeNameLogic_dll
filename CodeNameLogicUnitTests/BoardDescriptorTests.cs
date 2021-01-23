using CodeNameLogic.BoardModels;
using CodeNameLogic.CardModels;
using CodeNameLogic.TeamModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeNameLogicUnitTests
{
    [TestClass]
    public class BoardDescriptorTests
    {
        private BoardDescriptor _testBoard;

        [TestInitialize]
        public void CreateBoardDescriptor()
        {
            CardRole[,] roles = new CardRole[3, 3] {
               { CardRole.BlueTeam, CardRole.BlueTeam, CardRole.BlueTeam },
               { CardRole.RedTeam, CardRole.RedTeam, CardRole.RedTeam },
               { CardRole.Observer, CardRole.Observer, CardRole.RedTeam }
            };
            _testBoard = new BoardDescriptor(roles);
        }

        [TestMethod]
        public void Should_CountTeamCards_When_IndexerCalled()
        {
            Assert.IsTrue(_testBoard[TeamOptions.RedTeam] == 4);
            Assert.IsTrue(_testBoard[TeamOptions.BlueTeam] == 3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Should_ThrowArgumentException_When_IndexesOutOfBounds()
        {
            _ = _testBoard[15, 20];
        }

        [TestMethod]
        public void Should_GetCardRole_When_CardInBoardBounds()
        {
            Assert.IsTrue(_testBoard[1, 1] == CardRole.RedTeam);
        }
    }
}
