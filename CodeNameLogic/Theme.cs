using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace CodeNameLogic
{
    public class Theme
    {
        public string ThemeDecorationResPath { get; set; }

        public Color ThemeColor { get; set; }

        Theme(string themeRes, Color color)
        {
            ThemeDecorationResPath = themeRes;
            ThemeColor = color;
        }
    }
}
