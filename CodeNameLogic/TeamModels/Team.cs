using CodeNameLogic.TeamModels.PlayerModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNameLogic.TeamModels
{
    public class Team
    {
        public uint Id { get; private set; }

        public SpyMasterPlayer SpyMaster { get; private set; }

        public FieldOperativePlayer FieldOperative { get; private set; }
        
        public Team(uint id, SpyMasterPlayer spyMaster, FieldOperativePlayer fieldOperative)
        {
            if (spyMaster == null || fieldOperative == null)
            {
                throw new ArgumentNullException("One or more of the players are null");
            }

            Id = id;
            SpyMaster = spyMaster;
            FieldOperative = fieldOperative;
        }
    }
}
