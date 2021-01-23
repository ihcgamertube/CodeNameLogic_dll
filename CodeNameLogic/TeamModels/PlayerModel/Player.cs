using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNameLogic.TeamModels.PlayerModel
{
    public abstract class Player
    {
        public uint Id { get; set; }

        public string Username { get; protected set; }

        public uint RankLevel { get; private set; }

        public Player(uint id, string username, uint rank)
        {
            if (String.IsNullOrEmpty(username))
            {
                throw new ArgumentException("Username must not be empty");
            }

            Id = id;
            Username = username;
            RankLevel = rank;
        }
    }
}
