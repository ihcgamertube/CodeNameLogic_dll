using CodeNameLogic.GameModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNameLogicUnitTests
{
    [TestClass]
    public class GameCardTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Should_ThrowException_When_WordInvalid()
        {
            GameCard card = new GameCard(0, "");
            GameCard card2 = new GameCard(0, null);
        }

        [TestMethod]
        public void Should_CreateGameCard_When_ValuesValid()
        {
            GameCard card = new GameCard(0, "Wall");
            Assert.IsNotNull(card);
        }
    }
}
