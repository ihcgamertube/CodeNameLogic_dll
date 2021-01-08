using CodeNameLogic.TeamModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNameLogic.GameEvents
{
    //TODO: Create & Design Event architecture
    public static class GameEventsModels
    {
        public static void EventTeamWon(Team team)
        {
            Console.WriteLine("Team {0} Won The Game", team.TeamOption.ToString());
        }

        public static void EventTeamLost(Team team)
        {
            Console.WriteLine("Team {0} Lost The Game", team.TeamOption.ToString());
        }
    }
}
