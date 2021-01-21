using CodeNameLogic.BoardModels;
using CodeNameLogic.GameEvents;
using CodeNameLogic.ScoreTrackerModels;
using CodeNameLogic.TeamModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNameLogic
{
    public delegate void TeamWon(Team team);
    public delegate void TeamLost(Team team);

    public class TopLevelGame
    {
        protected Team[] _team;
        protected Board _board;
        protected ScoreTracker _scoreTracker;

        public TopLevelGame(Board board, Team[] team)
        {
            if (board == null || team == null)
            {
                throw new ArgumentException("Empty Args");
            }

            _board = board;
            _team = team;

            _scoreTracker = new ScoreTracker(team, board.BoardCardsDescriptor);
            _scoreTracker._teamWonDelgate  += GameEventsModels.EventTeamWon;
            _scoreTracker._teamLostDelgate += GameEventsModels.EventTeamLost;
        }

        void StartGame()
        {
            // TODO: notify users that game is starting
        }
    }
}
