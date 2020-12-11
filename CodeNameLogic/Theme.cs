using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace CodeNameLogic
{
    class Theme
    {
        public Color ThemeColor { get; set; }

        public string ThemeDecorationImage { get; set; }

        Theme(Color color) => (ThemeColor) = (color);
    }
}
