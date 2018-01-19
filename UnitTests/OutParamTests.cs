using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;

namespace UnitTests
{
    [TestClass]
    public class OutParamTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 1, 3, 5, 7, 9, 4, 6 };
            int oddCount = 0;
            int evenCount = WithOutParam.CountOddAndEven(a, out oddCount);
            Assert.AreEqual(evenCount, 2);
            Assert.AreEqual(oddCount, 5);
        }
    }
}
