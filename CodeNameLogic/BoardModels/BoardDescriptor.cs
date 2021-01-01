using System;
using System.Collections.Generic;
using System.Text;
using CodeNameLogic.CardModels;

namespace CodeNameLogic.BoardModels
{
    public class BoardDescriptor
    {
        public CardRole[,] CardRoles { get; private set; }

        public BoardDescriptor(CardRole[,] cardRoles)
        {
            CardRoles = cardRoles;
        }

        public CardRole this[int row, int col]
        {
            get 
            {
                if (row >= CardRoles.GetLength(0) || col >= CardRoles.GetLength(1))
                {
                    throw new ArgumentOutOfRangeException("Rows or Columns limit exceeded");
                }
                else if (row <= 0 || col <= 0)
                {
                    throw new ArgumentOutOfRangeException("Rows or Columns must be a postive integer");
                }

                return CardRoles[row, col]; 
            }
        }
    }
}
