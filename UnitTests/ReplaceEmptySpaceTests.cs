using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GreenBook.StringAndArray;

namespace UnitTests
{
    [TestClass]
    public class ReplaceEmptySpaceTests
    {
        [TestMethod]
        public void IceCreamString()
        {
            string s = "I love icecream    ";
            var result = ReplaceEmptySpace.ReplaceSpace(s);

            Assert.AreEqual("I%20love%20icecream", result);
        }

        [TestMethod]
        public void SmithString()
        {
            string s = "Mr John Smith hello      ";
            var result = ReplaceEmptySpace.ReplaceSpace(s);
            Assert.AreEqual("Mr%20John%20Smith%20hello", result);
        }
    }
}
