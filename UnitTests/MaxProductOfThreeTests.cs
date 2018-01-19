using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.DynamicProgramming;

namespace UnitTests
{
    [TestClass]
    public class MaxProductOfThreeTests
    {
        [TestMethod]
        public void MaxProductOfThree_test()
        {
            int[] a = { 1, 2, 3, -4, -4 };
            var result = MaxProductOfThree.GetMaxProductOfThree(a);
            Assert.AreEqual(result, 48);
        }
    }
}
