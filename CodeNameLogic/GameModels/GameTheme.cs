﻿using CodeNameLogic.ThemeModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNameLogic.GameModels
{
    public class GameTheme
    {
        public Theme CardTheme { get; set; }

        public Theme BoardTheme { get; set; }

        public GameTheme() { }
        public GameTheme(Theme cardTheme, Theme boardTheme)
        {
            CardTheme = cardTheme;
            BoardTheme = boardTheme;
        }

    }
}
