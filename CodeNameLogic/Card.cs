using System;

namespace CodeNameLogic
{
    public class Card
    {
        public uint Id { get; set; }

        public string Word { get; set; }

        public Card(uint id = 0, string word = "") => (Id, Word) = (id, word);
    }
}
