using CodeNameLogic.TeamModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNameLogic.TurnMangger
{
    public class TurnMannger
    {
        private readonly Team[] _teams;

        protected uint _teamTurnsCounter;

        protected Team CurrentTeam { get; private set; }
        
        // Note: Teams must be sorted by turns
        public TurnMannger(Team[] teams, Team startingTeam)
        {
            if (teams == null || startingTeam == null)
            {
                throw new ArgumentNullException("Teams or Starting team can not be null");
            }

            _teams = teams;
            CurrentTeam = startingTeam;

            _teamTurnsCounter = 0;
        }

        public Team NextTurn()
        {
            if (++_teamTurnsCounter == _teams.Length)
            {
                _teamTurnsCounter = 0;
            }

            return _teams[_teamTurnsCounter];
        }
    }
}
