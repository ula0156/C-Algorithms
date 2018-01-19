using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Array;

namespace UnitTests
{
    [TestClass]
    public class FindElementInRotatedArrayTests
    {
        [TestMethod]
        public void RotatedArray_elementExist()
        {
            int[] a = { 5, 6, 1, 2, 3, 4 };
            var n = 5;
            var result = FindElementInRotatedArray._FindElementInRotatedArray(a, n, 0, a.Length - 1);
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void RotatedArray_elementExist2()
        {
            int[] a = { 5, 6, 7, 8, 9, 10, 4 };
            var n = 4;
            var result = FindElementInRotatedArray._FindElementInRotatedArray(a, n, 0, a.Length - 1);
            Assert.AreEqual(result, 6);
        }

        [TestMethod]
        public void RotatedArray_elementNotExist()
        {
            int[] a = { 5, 6, 7, 8, 9, 10, 4 };
            var n = 13;
            var result = FindElementInRotatedArray._FindElementInRotatedArray(a, n, 0, a.Length - 1);
            Assert.AreEqual(result, -1);
        }
    }
}
