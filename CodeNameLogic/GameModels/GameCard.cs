using CodeNameLogic.CardModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNameLogic.GameModels
{
    public class GameCard : Card
    {
        public bool IsActive { get; set; }

        public GameCard(uint id, string word) : 
            base(id, word)
        {

        }
    }
}
