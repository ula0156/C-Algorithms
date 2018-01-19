using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Stack;

namespace UnitTests
{
    [TestClass]
    public class BiggestNeighborTests
    {
        [TestMethod]
        public void BiggestNeighborTests1()
        {
            int[] a = { 2, 7, 1, 3, 1, 2 };
            var result = BiggestNeighbor.GetBiggestNeighbor(a);
            CollectionAssert.AreEqual(result, new int[] { 1, -1, 1, 1, 3, 3 });
        }
    }
}
