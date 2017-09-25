using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class BandNameTest
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("The Knife", BandName.Generate("knife"));
            Assert.AreEqual("Tartart", BandName.Generate("tart"));
            Assert.AreEqual("Sandlesandles", BandName.Generate("sandles"));
            Assert.AreEqual("The Bed", BandName.Generate("bed"));
        }

        public class BandName
        {
            public static string Generate(string s)
            {
                var startIndex = s.Substring(0, 1);
                var endIndex = s.Substring(s.Length - 1, 1);

                if (startIndex == endIndex)
                    return char.ToUpper(s[0]) + s.Substring(1) + s.TrimStart(startIndex.ToCharArray());

                else
                    return "The " + char.ToUpper(s[0]) + s.Substring(1);
            }
        }
    }
}
