using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.LeetCode;

namespace UnitTests
{
    [TestClass]
    public class AtoiTests
    {
        [TestMethod]
        public void Atoi_test1()
        {
            var s = "   - 321";
            var result = Atoi.MyAtoi(s);
            Assert.AreEqual(0, result);
        }
    }
}
