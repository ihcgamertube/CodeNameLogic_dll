using CodeNameLogic.TeamModels.PlayerModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNameLogic.TeamModels
{
    public class Team
    {
        public uint Id { get; private set; }

        public TeamOptions TeamOption { get; private set; }

        public SpyMasterPlayer SpyMaster { get; private set; }

        public FieldOperativePlayer FieldOperative { get; private set; }
        
        public Team(uint id, TeamOptions teamOption, SpyMasterPlayer spyMaster, FieldOperativePlayer fieldOperative)
        {
            if (spyMaster == null || fieldOperative == null)
                throw new ArgumentNullException("One or more of the players are null");

            if (spyMaster.Equals(fieldOperative))
                throw new ArgumentException("Team Players have matching id and names");

            Id = id;
            TeamOption = teamOption;
            SpyMaster = spyMaster;
            FieldOperative = fieldOperative;
        }
    }
}
