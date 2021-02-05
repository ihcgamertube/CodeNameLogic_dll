using CodeNameLogic.BoardModels.BoardDescriptorStrategies;
using CodeNameLogic.CardModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNameLogicUnitTests
{
    [TestClass]
    public class RandomizerCreatorStrategyTests
    {
        [TestMethod]
        public void Should_GenerateRandomizedCardRoles_When_ValuesInBounds()
        {
            IBoardDescriptorCreatorStrategy strategy = new RandomizerCreatorStrategy();
            int rows = 5;
            int collums = 5;
            int teamsCount = 2;

            CardRole[,] randomRoles = strategy.GenerateCardRoles(rows, collums, teamsCount);
            Assert.IsNotNull(randomRoles);
        }
    }
}
