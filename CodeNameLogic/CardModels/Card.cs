using System;

namespace CodeNameLogic.CardModels
{
    public class Card
    {
        public uint Id { get; set; }

        public string Word { get; set; }

        public Card(uint id, string word)
        {
            if (String.IsNullOrEmpty(word))
                throw new ArgumentException("Word must not be empty");

            Id = id;
            Word = word;
        }
    }
}
