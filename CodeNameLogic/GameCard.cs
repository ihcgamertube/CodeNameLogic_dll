using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNameLogic
{
    public class GameCard : Card
    {
        public bool IsActive { get; set; }

        public GameCard(uint id = 0, string word = "") : 
            base(id, word)
        {

        }
    }
}
