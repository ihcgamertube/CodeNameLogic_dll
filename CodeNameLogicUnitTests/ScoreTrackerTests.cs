using CodeNameLogic.BoardModels;
using CodeNameLogic.CardModels;
using CodeNameLogic.ScoreTrackerModels;
using CodeNameLogic.TeamModels;
using CodeNameLogic.TeamModels.PlayerModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CodeNameLogicUnitTests
{
    [TestClass]
    public class ScoreTrackerTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Should_ThrowException_When_ArgumentsAreNull()
        {
            BoardDescriptor nullBoard = null;
            Team[] teams = new Team[5];

            ScoreTracker tracker = new ScoreTracker(teams, nullBoard);
        }

        [TestMethod]
        public void Should_InformScoreAtFinish_When_TrackingIsValid()
        {
            CardRole[,] roles = new CardRole[2, 2] {
               { CardRole.BlueTeam, CardRole.BlueTeam},
               { CardRole.Observer, CardRole.Observer}
            };
            BoardDescriptor boardDescriptor = new BoardDescriptor(roles);
            SpyMasterPlayer player1 = new SpyMasterPlayer(0, "SpyBro", 1);
            FieldOperativePlayer player2 = new FieldOperativePlayer(1, "FieldBro", 1);
            Team team = new Team(0, TeamOptions.BlueTeam, player1, player2);

            Team[] teams = new Team[1] { team };

            ScoreTracker scoreTracker = new ScoreTracker(teams, boardDescriptor);
            scoreTracker.UpdateScore(team.TeamOption);
            scoreTracker.UpdateScore(team.TeamOption);
            Assert.IsTrue(scoreTracker[team.TeamOption].RemainingCards == 0);
        }
    }
}
