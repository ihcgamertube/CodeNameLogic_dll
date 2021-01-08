using System;
using System.Collections.Generic;
using System.Text;
using CodeNameLogic.CardModels;
using CodeNameLogic.TeamModels;

namespace CodeNameLogic.BoardModels
{
    public class BoardDescriptor
    {
        public CardRole[,] CardRoles { get; private set; }

        public BoardDescriptor(CardRole[,] cardRoles)
        {
            CardRoles = cardRoles;
        }

        public uint this[TeamOptions teamOption]
        {
            get
            {
                uint counter = 0;
                for (int i = 0; i < CardRoles.GetLength(0); i++)
                {
                    for (int j = 0; j < CardRoles.GetLength(1); j++)
                    {
                        if ((char)CardRoles[i, j] == (char)teamOption)
                        {
                            counter++;
                        }
                    }
                }
                return counter;
            }
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
