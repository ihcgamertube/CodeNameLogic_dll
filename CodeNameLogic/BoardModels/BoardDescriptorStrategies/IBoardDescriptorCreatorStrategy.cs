using CodeNameLogic.CardModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNameLogic.BoardModels.BoardDescriptorStrategies
{
    public interface IBoardDescriptorCreatorStrategy
    {
        public CardRole[,] GenerateCardRoles(int rows, int collumns, int teamsCounts); 
    }
}
