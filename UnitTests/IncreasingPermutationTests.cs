using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Permutations;

namespace UnitTests
{
    [TestClass]
    public class IncreasingPermutationTests
    {
        [TestMethod]
        public void IncreasingPermutation_Test1()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int n = 3;
            var result = IncreasingPermutation.GetPermut(a, n);

            var x = 0;
        }
    }
}
