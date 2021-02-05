using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNameLogic.TeamModels.PlayerModel
{
    public class SpyMasterPlayer : Player
    {
        public SpyMasterPlayer(uint id, string username, uint rank) : 
            base(id, username, rank) {}
    }
}
