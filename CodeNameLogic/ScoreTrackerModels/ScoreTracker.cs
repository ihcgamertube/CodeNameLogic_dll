using CodeNameLogic.TeamModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CodeNameLogic.BoardModels;

namespace CodeNameLogic.ScoreTrackerModels
{

    public class TeamScore
    {
        public Team Team { get; set; }

        public uint RemainingCards { get; set; }

        public TeamScore(Team team, uint remainingCards)
        {
            Team = team;
            RemainingCards = remainingCards;
        }
    }

    public class ScoreTracker
    {
        public TeamWon  _teamWonDelgate;
        public TeamLost _teamLostDelgate;

        private Dictionary<TeamOptions, TeamScore> _teamsScore;

        // Note: team[i] must 
        public ScoreTracker(Team[] teams, BoardDescriptor boardDescriptor)
        {
            if (teams == null || boardDescriptor == null)
                throw new ArgumentNullException("Teams or BoardDescriptor Are Null");

            _teamsScore = new Dictionary<TeamOptions, TeamScore>();

            // find a better way to insert a Team array
            // into a dictionary

            foreach (var team in teams)
            {
                uint remainingCards = boardDescriptor[team.TeamOption];
                _teamsScore.Add(team.TeamOption, new TeamScore(team, remainingCards));
            }
        }

        public void UpdateScore(TeamOptions teamOptions)
        {
            if (_teamsScore == null)
                throw new NullReferenceException("Teams Scores isn't innitiallized");

            if (!_teamsScore.ContainsKey(teamOptions))
                throw new ArgumentException("Team requested isn't in scores tracker");

            _teamsScore[teamOptions].RemainingCards--;

            if (_teamsScore[teamOptions].RemainingCards == 0)
            {
                //Notify
                _teamWonDelgate?.Invoke(_teamsScore[teamOptions].Team);
                foreach(var team in _teamsScore.Values.Select((teamScore) => { return teamScore.Team; }))
                {
                    if (team.TeamOption != teamOptions)
                    {
                        _teamLostDelgate?.Invoke(team);
                    }
                }
            }
        }

        public TeamScore this[TeamOptions teamOption]
        {
            get
            {
                return _teamsScore[teamOption];
            }
        }
    }
}
