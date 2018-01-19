using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Array;

namespace UnitTests
{
    [TestClass]
    public class BiggestConsecutiveSumTests
    {
        [TestMethod]
        public void TesBiggestConsecutiveSumTests1()
        {
            int[] a = new int[] { 1, -2, 3, -1, 4 };
            var result = BiggestConsecutiveSum._BiggestConsecutiveSum(a);
            Assert.AreEqual(result, 6);
        }

        [TestMethod]
        public void TesBiggestConsecutiveSumTests2()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5 };
            var result = BiggestConsecutiveSum._BiggestConsecutiveSum(a);
            Assert.AreEqual(result, 15);
        }

        [TestMethod]
        public void TesBiggestConsecutiveSumTests3()
        {
            int[] a = new int[] { 1, -10, 3, -6, -1 };
            var result = BiggestConsecutiveSum._BiggestConsecutiveSum(a);
            Assert.AreEqual(result, 3);
        }
    }
}
