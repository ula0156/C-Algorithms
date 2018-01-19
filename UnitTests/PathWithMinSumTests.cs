using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Array;

namespace UnitTests
{
    [TestClass]
    public class PathWithMinSumTests
    {
        [TestMethod]
        public void PathWithMinSum_Test1()
        {
            var mat = new int[][] { new int[] { 2 }, new int[] { 1, 3 }, new int[] { 6, 10, 1 }, new int[] { 5, 4, 6, 3 } };
            var result = PathWithMinSum.GetMinSum(mat);
            Assert.AreEqual(result, 9);
        }

        public void PathWithMinSum_RecusionTest1()
        {
            var mat = new int[][] { new int[] { 2 }, new int[] { 1, 3 }, new int[] { 6, 10, 1 }, new int[] { 5, 4, 6, 3 } };
            var result = PathWithMinSum.GetMinSumRecusive(mat, 0, 0);
            Assert.AreEqual(result, 9);
        }
    }
}
