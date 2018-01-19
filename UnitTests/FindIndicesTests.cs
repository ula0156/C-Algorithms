using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GreenBook.StringAndArray;

namespace UnitTests
{
    [TestClass]
    public class FindIndicesTests
    {
        [TestMethod]
        public void FindIndices_Test1()
        {
            int[] a = { 1, 2, 4, 7, 10, 11, 7, 12, 6, 7, 16, 18, 19 };
            var result = FindIndices.FindIndicesToSort(a);
            Assert.AreEqual(result, new Tuple<int, int>(3, 9));
        }

        [TestMethod]
        public void FindIndices_Test2()
        {
            int[] a = { 1, 2, 4, 7, 10, 11, 2, 7, 12, 6, 7, 16, 18, 19 };
            var result = FindIndices.FindIndicesToSort(a);
            Assert.AreEqual(result, new Tuple<int, int>(2, 10));
        }
    }
}
