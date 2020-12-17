using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNameLogic
{
    public class BoardDescriptor
    {
        public CardRole[,] CardRoles { get; set; }

        public BoardDescriptor(uint rows, uint colummns)
        {
            CardRoles = new CardRole[rows, colummns];
        }

        // return card role by reference
        public ref CardRole SetCardRole(uint row, uint column)
        { 
            return ref CardRoles[row, column];
        }

    }
}
