using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNameLogic
{
    public class BoardDescriptor
    {
        public CardRole[,] CardRoles { get; set; }

        public BoardDescriptor(uint rows, uint columns)
        {
            if (rows <= 0 || columns <= 0)
            {
                throw new Exception("Rows or Columns must be a postive integer");
            }

            CardRoles = new CardRole[rows, columns];
        }
    }
}
