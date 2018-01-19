using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test;

namespace UnitTests
{
    [TestClass]
    public class SquareRootTests
    {
        [TestMethod]
        public void SquareRoot_24()
        {
            int n = 24;
            var result = SquareRoot.FindSquareRoot(n, 0, n);
            Assert.AreEqual(result, 4);
        }

        [TestMethod]
        public void SquareRoot_9()
        {
            int n = 9;
            var result = SquareRoot.FindSquareRoot(n, 0, n);
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void SquareRoot_30()
        {
            int n = 30;
            var result = SquareRoot.FindSquareRoot(n, 0, n);
            Assert.AreEqual(result, 5);
        }

        [TestMethod]
        public void SquareRoot_15()
        {
            int n = 15;
            var result = SquareRoot.FindSquareRoot(n, 0, n);
            Assert.AreEqual(result, 3);
        }
    }
}
