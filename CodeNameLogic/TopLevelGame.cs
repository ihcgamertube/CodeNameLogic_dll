using CodeNameLogic.BoardModels;
using CodeNameLogic.TeamModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNameLogic
{
    public class TopLevelGame
    {
        protected Team[] _team;
        protected Board _board;

        public TopLevelGame(Board board, Team[] team)
        { 
            _board = board;
            _team = team;        
        }

        void StartGame()
        {
            // notify users

        }

    }
}
