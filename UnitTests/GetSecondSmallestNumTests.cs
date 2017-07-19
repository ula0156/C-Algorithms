using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;

namespace UnitTests
{
    [TestClass]
    public class SecondSmallestTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 1, 5, 0, 12, 6, 2};
            int secondSmallest;
            Assert.IsTrue(SecondSmallest.TryGetSecondSmallest(a, out secondSmallest));
            Assert.AreEqual(secondSmallest, 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] a = { 1, 5, 12, 6, 2 };
            int secondSmallest;
            Assert.IsTrue(SecondSmallest.TryGetSecondSmallest(a, out secondSmallest));
            Assert.AreEqual(secondSmallest, 2);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] a = { 0, 2, 0, 12, 6, 1 };
            int secondSmallest;
            Assert.IsTrue(SecondSmallest.TryGetSecondSmallest(a, out secondSmallest));
            Assert.AreEqual(secondSmallest, 1);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] a = { 1, 0 };
            int secondSmallest;
            Assert.IsTrue(SecondSmallest.TryGetSecondSmallest(a, out secondSmallest));
            Assert.AreEqual(secondSmallest, 1);
        }

        [TestMethod]
        public void TestMethod5()
        {
            int[] a = { 0, 2, 0, 1, 6, 1 };
            int secondSmallest;
            Assert.IsTrue(SecondSmallest.TryGetSecondSmallest(a, out secondSmallest));
            Assert.AreEqual(secondSmallest, 1);
        }

        [TestMethod]
        public void TestOneElement()
        {
            int[] a = { 0 };
            int result;
            Assert.IsFalse(SecondSmallest.TryGetSecondSmallest(a, out result));
        }

        [TestMethod]
        public void TestAllSame()
        {
            int[] a = { 0, 0, 0 };
            int result;
            Assert.IsFalse(SecondSmallest.TryGetSecondSmallest(a, out result));
        }

        [TestMethod]
        public void TestEmpty()
        {
            int[] a = { };
            int result;
            Assert.IsFalse(SecondSmallest.TryGetSecondSmallest(a, out result));
        }
    }
}
