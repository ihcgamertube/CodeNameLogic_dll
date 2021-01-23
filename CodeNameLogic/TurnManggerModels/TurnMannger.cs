using CodeNameLogic.TeamModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeNameLogic.TurnManggerModels
{
    public class TurnMannger
    {
        private readonly Team[] _teams;

        protected uint _teamTurnsCounter;

        protected uint _totalTurns;

        public TeamOptions CurrentTeam { get; private set; }
        
        // Note: Teams must be sorted by turns
        public TurnMannger(Team[] teams, TeamOptions startingTeam)
        {
            if (teams == null || teams.Contains(null))
            {
                throw new ArgumentNullException("Teams can not be null");
            }

            if(teams[0].TeamOption != startingTeam)
            {
                bool didSwapOccured = false;
                for(int i = 1; i < teams.Length; i++)
                {
                    if(teams[i].TeamOption == startingTeam)
                    {
                        Team tempTeam = teams[0];
                        teams[0] = teams[i];
                        teams[i] = tempTeam;
                        didSwapOccured = true;
                        break;
                    }
                }
                if (!didSwapOccured)
                    throw new ArgumentException("Team array isn't sorted properly.");
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

            CurrentTeam = _teams[_teamTurnsCounter].TeamOption;
            return _teams[_teamTurnsCounter];
        }
    }
}
