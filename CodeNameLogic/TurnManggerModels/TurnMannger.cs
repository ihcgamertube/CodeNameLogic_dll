using CodeNameLogic.TeamModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNameLogic.TurnManggerModels
{
    public class TurnMannger
    {
        private readonly Team[] _teams;

        protected uint _teamTurnsCounter;

        protected uint _totalTurns;

        protected TeamOptions CurrentTeam { get; private set; }
        
        // Note: Teams must be sorted by turns
        public TurnMannger(Team[] teams, TeamOptions startingTeam)
        {
            if (teams == null)
            {
                throw new ArgumentNullException("Teams can not be null");
            }

            _teams = teams;
            CurrentTeam = startingTeam;

            _teamTurnsCounter = 0;
            _totalTurns = 0;
        }

        public Team NextTurn()
        {
            _totalTurns++;

            if (++_teamTurnsCounter == _teams.Length)
            {
                _teamTurnsCounter = 0;
            }

            return _teams[_teamTurnsCounter];
        }
    }
}
