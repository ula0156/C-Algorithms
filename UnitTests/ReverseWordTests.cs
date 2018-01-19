using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Strings;

namespace UnitTests
{
    [TestClass]
    public class ReverseWordTests
    {
        [TestMethod]
        public void ReverseWord_test1()
        {
            var s = "Hello";
            var result = ReverseWord.ReverseString(s);
            Assert.AreEqual(result, "olleH");
        }
    }
}
