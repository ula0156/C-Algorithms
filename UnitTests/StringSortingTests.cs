using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights;

namespace StringSortingTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string s = "weather";
            string t = "therapyw";
            string result = StringSorting.sortByString(s, t);
            Assert.AreEqual(result, "theeraw");
        }
    }
}
