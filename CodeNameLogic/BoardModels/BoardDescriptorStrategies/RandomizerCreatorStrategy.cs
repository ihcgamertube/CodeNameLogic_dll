using CodeNameLogic.CardModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeNameLogic.BoardModels.BoardDescriptorStrategies
{
    public class RandomizerCreatorStrategy : IBoardDescriptorCreatorStrategy
    {
        public CardRole[,] GenerateCardRoles(int rows, int collumns, int teamsCounts = 2)
        {
            if (rows <= 0 || collumns <= 0)
                throw new ArgumentOutOfRangeException("Board Size Impossible");

            Random rnd = new Random();
            int numOfCards = (rows * collumns) - 1;
            int cardsPerTeam = numOfCards / (teamsCounts + 1);

            Dictionary<CardRole, int> assignableCardsCounters = new Dictionary<CardRole, int>()
            {
                { CardRole.RedTeam, cardsPerTeam + 1 },
                { CardRole.BlueTeam, cardsPerTeam},
                { CardRole.Observer, numOfCards - (cardsPerTeam + 1) - cardsPerTeam },
                { CardRole.StrikeCard, 1 }
            };

            CardRole[,] shuffledCardRoles = new CardRole[rows, collumns];

            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < collumns; j++)
                {
                    int cardRoleRandomIndex = rnd.Next(0, assignableCardsCounters.Count);
                    CardRole randomCardRole = assignableCardsCounters.AsEnumerable().ElementAt(cardRoleRandomIndex).Key;
                    shuffledCardRoles[i, j] = randomCardRole;
                    assignableCardsCounters[randomCardRole]--;

                    if (assignableCardsCounters[randomCardRole] == 0)
                        assignableCardsCounters.Remove(randomCardRole);
                }
            }

            return shuffledCardRoles;
        }
    }
}
