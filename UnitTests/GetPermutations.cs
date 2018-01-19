using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Permutations;

namespace UnitTests
{
    [TestClass]
    public class GetPermutationsTests
    {
        [TestMethod]
        public void PermutationsVoidWithArr()
        {
            int[] a = new int[] { -1, -1, -1 };
            int pos = 0;
            int k = 3;
            var result = IterativePermutations.Permutations(a, pos, k);
            Assert.AreEqual(result.Count, 27);
            CollectionAssert.AreEqual(result[10], new int[] { 1, 0, 1 });
        }
    }
}
