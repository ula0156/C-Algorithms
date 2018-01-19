using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.LeetCode;

namespace UnitTests
{
    [TestClass]
    public class ReplaceDigitsTests
    {
        [TestMethod]
        public void ReplaceDigitsTests_1()
        {
            var num = 1993;
            var result = ReplaceDigits.MaximumSwap(num);
            Assert.AreEqual(result, 9913);
        }
    }
}
