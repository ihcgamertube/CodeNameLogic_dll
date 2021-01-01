using System;

namespace CodeNameLogic.CardModels
{
    public class Card
    {
        public uint Id { get; set; }

        public string Word { get; set; }

        public Card(uint id, string word)
        {
            Id = id;
            Word = word;
        }
    }
}
