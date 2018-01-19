using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Array;

namespace UnitTests
{
    [TestClass]
    public class QuickSortTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = new int[4] { 1, 4, 3, 2 };
            QuickSort.QuickSorts(a, 0, a.Length);
            CollectionAssert.AreEqual(new int[4] { 1, 2, 3, 4 }, a);
        }
    }
}
