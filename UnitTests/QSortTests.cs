using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;

namespace UnitTests
{
    [TestClass]
    public class QSortTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 7, 1, 3, 8, 4, 2, 0 };
            int[] b = { 0, 1, 2, 3, 4, 7, 8 };
            int stInd = 0;
            int endInd = a.Length;
            QSort.QuickSort(a, stInd, endInd);
            CollectionAssert.AreEqual(a, b);
        }
    }
}
