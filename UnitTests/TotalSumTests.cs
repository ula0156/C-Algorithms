using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Strings;

namespace UnitTests
{
    [TestClass]
    public class TotalSumTests
    {
        [TestMethod]
        public void GetTotalSum_Test1()
        {
            var s = "20_apple: 5  7   ,  pears:  3, dog_fluffy: 1000  , potatoes: 1   2,";
            var result = TotalSum.GetTotalSum(s);
            Assert.AreEqual(result, 1040);
        }
    }
}
