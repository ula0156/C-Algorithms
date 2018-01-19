using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.GreedyApproach;

namespace UnitTests
{
    [TestClass]
    public class LongestIncreasingSubsequenceTests
    {
        [TestMethod]
        public void LongestIncreasingSubsequence_1()
        {
            int[] a = new int[] { 1, 3, 5, 4, 7 };
            var result = LongestIncreasingSubsequence.FindNumberOfLIS(a);
            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void LongestIncreasingSubsequence_2()
        {
            int[] a = new int[] { 2, 2, 2, 2, 2 };
            var result = LongestIncreasingSubsequence.FindNumberOfLIS(a);
            Assert.AreEqual(result, 5);
        }

        [TestMethod]
        public void LongestIncreasingSubsequence_3()
        {
            int[] a = new int[] { 1, 2, 4, 3, 5, 4, 7, 2 };
            var result = LongestIncreasingSubsequence.FindNumberOfLIS(a);
            Assert.AreEqual(result, 3);
        }
    }
}
