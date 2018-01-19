using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Array;

namespace UnitTests
{
    [TestClass]
    public class MagicIndexTests
    {
        [TestMethod]
        public void MagicIndex1()
        {
            int[] a = { -1, 0, 2, 5, 6, 7, 8 };
            var result = MagicIndex._MagicIndex(a, 0, a.Length - 1);
            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void MagicIndex2()
        {
            int[] a = { -1, 0, 3, 5, 6, 7, 8 };
            var result = MagicIndex._MagicIndex(a, 0, a.Length - 1);
            Assert.AreEqual(result, -1);
        }

        [TestMethod]
        public void MagicIndex3()
        {
            int[] a = { -3, -2, -1, 0, 4 };
            var result = MagicIndex._MagicIndex(a, 0, a.Length - 1);
            Assert.AreEqual(result, 4);
        }
    }
}
