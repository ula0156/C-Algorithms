using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.DynamicProgramming;

namespace UnitTests
{
    [TestClass]
    public class FindNumberOfWaysToFormSumTests
    {
        [TestMethod]
        public void FindNumberOfWaysToFormSum_sum15()
        {
            var sum = 11;
            int[] denominations = { 3, 5, 6 };
            var result = FindNumberOfWaysToFormSum.NumberOfWaysToFormSum(sum, denominations);
            Assert.AreEqual(result, 5);
        }

        [TestMethod]
        public void FindNumberOfWaysDynamic_sum15()
        {
            var sum = 11;
            int[] denominations = { 3, 5, 6 };
            var result = FindNumberOfWaysToFormSum.NumberOfWaysToFormSum2(sum, denominations);
            Assert.AreEqual(result, 5);
        }

        [TestMethod]
        public void FindNumberOfWaysDynamicByBook_sum15()
        {
            var sum = 11;
            int[] denominations = { 3, 5, 6 };
            var result = FindNumberOfWaysToFormSum.NumberOfWaysToFormSum2(sum, denominations);
            Assert.AreEqual(result, 5);
        }
    }
}
