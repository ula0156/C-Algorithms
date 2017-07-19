using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights;

namespace UnitTests
{
    [TestClass]
    public class GetSecondSmallestTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 1, 1, 2, 3, 3, 4, 4, 5, 5 };
            int stInd = 0;
            int endInd = a.Length - 1;
            int result = FindUnique.FindUniqueNumber(a, stInd, endInd);
            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] a = { 1, 2, 2, 3, 3, 4, 4 };
            int stInd = 0;
            int endInd = a.Length - 1;
            int result = FindUnique.FindUniqueNumber(a, stInd, endInd);
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] a = { 0 };
            int stInd = 0;
            int endInd = a.Length - 1;
            int result = FindUnique.FindUniqueNumber(a, stInd, endInd);
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] a = { 1, 1, 3, 3, 4, 4, 5};
            int stInd = 0;
            int endInd = a.Length - 1;
            int result = FindUnique.FindUniqueNumber(a, stInd, endInd);
            Assert.AreEqual(result, 5);
        }

        [TestMethod]
        public void TestMethod5()
        {
            int[] a = { 3, 4, 4 };
            int stInd = 0;
            int endInd = a.Length - 1;
            int result = FindUnique.FindUniqueNumber(a, stInd, endInd);
            Assert.AreEqual(result, 3);
        }
    }
}
