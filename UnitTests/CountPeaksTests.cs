using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;

namespace UnitTests
{
    [TestClass]
    public class CountPeaksTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 1, 2, 0, 7, 3, 8 };
            int result = CountPeaks.GetNumOfPeaks(a);
            Assert.AreEqual(result, 3);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] a = { 1, 2, 3, 0, 7, 8, 0};
            int result = CountPeaks.GetNumOfPeaks(a);
            Assert.AreEqual(result, 2);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int[] a = { 1, 2, 0 };
            int result = CountPeaks.GetNumOfPeaks(a);
            Assert.AreEqual(result, 1);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int[] a = { 1, 1, 1, 1, 1 };
            int result = CountPeaks.GetNumOfPeaks(a);
            Assert.AreEqual(result, 0);
        }
    }
}
