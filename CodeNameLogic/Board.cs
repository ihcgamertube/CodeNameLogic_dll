using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNameLogic
{
    public class Board
    {
        public delegate BoardDescriptor GetBoardDescriptorDelegate();

        public GameCard[,] GameCards { get; set; }

        public BoardDescriptor BoardCardsDescriptor { get; set; }

        public GameTheme BoardTheme { get; set; }

        public Board(uint rows, uint columns)
        {
            GameCards = new GameCard[rows, columns];
            BoardCardsDescriptor = new BoardDescriptor(rows, columns);
            BoardTheme = new GameTheme();
        }
    }
}
