using CodeNameLogic.TeamModels;
using CodeNameLogic.TeamModels.PlayerModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNameLogicUnitTests
{
    [TestClass]
    public class TeamTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Should_ThrowException_When_PlayerInTeamInvalid()
        {
            Player player = new SpyMasterPlayer(0, "Tamir", 1);
            Player player2 = null;

            Team team = new Team(0, TeamOptions.BlueTeam, (SpyMasterPlayer)player, (FieldOperativePlayer)player2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Should_ThrowException_When_PlayersInTeamHaveSameIdAndName()
        {
            SpyMasterPlayer player = new SpyMasterPlayer(0, "Tamir", 1);
            FieldOperativePlayer player2 = new FieldOperativePlayer(0, "Tamir", 1);

            Team team = new Team(0, TeamOptions.BlueTeam, player, player2);
        }

        [TestMethod]
        public void Should_CreateTeam_When_PlayerInTeamValid()
        {
            SpyMasterPlayer player = new SpyMasterPlayer(0, "Tamir", 1);
            FieldOperativePlayer player2 = new FieldOperativePlayer(0, "Nadav", 1);

            Team team = new Team(0, TeamOptions.BlueTeam, player, player2);
            Assert.IsNotNull(team);
        }
    }
}
