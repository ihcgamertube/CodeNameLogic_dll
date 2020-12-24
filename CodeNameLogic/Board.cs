using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNameLogic
{
    public class Board
    {
        const uint MAX_ROWS    = 10;
        const uint MAX_COLUMNS = 10;
        
        public GameCard[,] GameCards { get; set; }

        public BoardDescriptor BoardCardsDescriptor { get; set; }

        public GameTheme BoardTheme { get; set; }

        public Board(uint rows, uint columns)
        {
            if (rows >= MAX_ROWS || columns >= MAX_COLUMNS)
            {
                throw new Exception("Rows or Columns limit exceeded");
            }
            else if (rows <= 0 || columns <= 0)
            {
                throw new Exception("Rows or Columns must be a postive integer");
            }

            GameCards = new GameCard[rows, columns];
            BoardCardsDescriptor = new BoardDescriptor(rows, columns);
            BoardTheme = new GameTheme();
        }
    }
}
