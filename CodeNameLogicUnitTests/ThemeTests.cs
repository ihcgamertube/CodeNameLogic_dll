using CodeNameLogic.ThemeModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace CodeNameLogicUnitTests
{
    [TestClass]
    public class ThemeTests
    {
        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void Should_ThrowException_When_FileNotFound()
        {
            Theme theme = new Theme("f", Color.White);
        }
    }
}
