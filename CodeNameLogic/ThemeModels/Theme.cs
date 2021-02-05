using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;

namespace CodeNameLogic.ThemeModels
{
    public class Theme
    {
        public string ThemeDecorationResPath { get; set; }

        public Color ThemeColor { get; set; }

        public Theme(string themeRes, Color color)
        {
            if (!File.Exists(themeRes))
                throw new FileNotFoundException("Theme File Not Found in System.");
            ThemeDecorationResPath = themeRes;
            ThemeColor = color;
        }
    }
}
