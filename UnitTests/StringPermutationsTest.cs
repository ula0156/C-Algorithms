using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights;

namespace UnitTests
{
    [TestClass]
    public class StringPermutationsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] result = StringPermutations.Permutations("aab");
            Assert.AreEqual(3, result.Length);
            CollectionAssert.AreEqual(new string[] { "aab", "aba", "baa" }, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string[] result = StringPermutations.Permutations("CBA");
            CollectionAssert.AreEqual(new string[] { "ABC", "ACB", "BAC", "BCA", "CAB", "CBA"}, result);
        }
    }
}
