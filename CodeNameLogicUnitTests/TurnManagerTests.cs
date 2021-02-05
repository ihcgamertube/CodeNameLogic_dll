using CodeNameLogic.TeamModels;
using CodeNameLogic.TeamModels.PlayerModel;
using CodeNameLogic.TurnManggerModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNameLogicUnitTests
{
    [TestClass]
    public class TurnManagerTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Should_ThrowException_When_TeamsNull()
        {
            Team[] teams = null;
            TurnMannger turnMannger = new TurnMannger(teams, TeamOptions.RedTeam);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Should_ThrowException_When_InnerTeamsNull()
        {
            Team[] teams = { null };
            TurnMannger turnMannger = new TurnMannger(teams, TeamOptions.RedTeam);
        }

        [TestMethod]
        public void Should_ManageTurn_When_OneTeamInManager()
        {
            SpyMasterPlayer spyMasterPlayer = new SpyMasterPlayer(0, "Samir", 1);
            FieldOperativePlayer fieldOperativePlayer = new FieldOperativePlayer(1, "Nini", 1);
            Team team = new Team(0, TeamOptions.RedTeam, spyMasterPlayer, fieldOperativePlayer);
            Team[] teams = new Team[1] { team };

            TurnMannger turnMannger = new TurnMannger(teams, TeamOptions.RedTeam);
            Assert.IsTrue(turnMannger.NextTurn() == team);
        }

        [TestMethod]
        public void Should_ManageMultipleTurns_When_MoreThan1TeamInManager()
        {
            SpyMasterPlayer spyMasterPlayer = new SpyMasterPlayer(0, "Samir", 1);
            FieldOperativePlayer fieldOperativePlayer = new FieldOperativePlayer(1, "Nini", 1);
            Team team = new Team(0, TeamOptions.RedTeam, spyMasterPlayer, fieldOperativePlayer);
            Team team2 = new Team(1, TeamOptions.BlueTeam, spyMasterPlayer, fieldOperativePlayer);
            Team[] teams = new Team[2] { team, team2 };

            TurnMannger turnMannger = new TurnMannger(teams, TeamOptions.RedTeam);
            Assert.IsTrue(turnMannger.NextTurn() == team2);
            Assert.IsTrue(turnMannger.NextTurn() == team);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Should_ThrowException_When_TeamsArentSorted()
        {
            SpyMasterPlayer spyMasterPlayer = new SpyMasterPlayer(0, "Samir", 1);
            FieldOperativePlayer fieldOperativePlayer = new FieldOperativePlayer(1, "Nini", 1);
            Team team = new Team(0, TeamOptions.BlueTeam, spyMasterPlayer, fieldOperativePlayer);
            Team team2 = new Team(1, TeamOptions.BlueTeam, spyMasterPlayer, fieldOperativePlayer);
            Team[] teams = new Team[2] { team, team2 };

            TurnMannger turnMannger = new TurnMannger(teams, TeamOptions.RedTeam);
        }

        [TestMethod]
        public void Should_CreateTurnManager_When_TeamsNotAlreadySorted()
        {
            SpyMasterPlayer spyMasterPlayer = new SpyMasterPlayer(0, "Samir", 1);
            FieldOperativePlayer fieldOperativePlayer = new FieldOperativePlayer(1, "Nini", 1);
            Team team = new Team(0, TeamOptions.BlueTeam, spyMasterPlayer, fieldOperativePlayer);
            Team team2 = new Team(1, TeamOptions.RedTeam, spyMasterPlayer, fieldOperativePlayer);
            Team[] teams = new Team[2] { team, team2 };

            TurnMannger turnMannger = new TurnMannger(teams, TeamOptions.RedTeam);
        }
    }
}
