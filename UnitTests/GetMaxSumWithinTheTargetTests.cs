using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Recusion;

namespace UnitTests
{
    [TestClass]
    public class GetMaxSumWithinTheTargetTests
    {
        [TestMethod]
        public void GetMaxSumWithinTheTarget_Test1()
        {
            Tuple<int, int>[] arr = { new Tuple<int, int>(5, 7), new Tuple<int, int>(1, 2),
                new Tuple<int, int>(8, 9), new Tuple<int, int>(9, 11), new Tuple<int, int>(4, 6) };
            var target = 20;
            var result = GetMaxSumWithinTheTarget.GetSum(arr, arr.Length - 1, target);
            Assert.AreEqual(result, 17);
        }

        [TestMethod]
        public void GetMaxSumWithinTheTarget_Test2()
        {
            Tuple<int, int>[] arr = { new Tuple<int, int>(5, 7), new Tuple<int, int>(1, 2),
                                      new Tuple<int, int>(8, 9), new Tuple<int, int>(9, 11), new Tuple<int, int>(7, 9) };
            var target = 18;
            var result = GetMaxSumWithinTheTarget.GetSum(arr, arr.Length - 1, target);
            Assert.AreEqual(result, 15);
        }

        [TestMethod]
        public void GetMaxSumWithinTheTarget_Test3DP()
        {
            Tuple<int, int>[] arr = { new Tuple<int, int>(5, 7), new Tuple<int, int>(1, 2),
                                      new Tuple<int, int>(8, 9), new Tuple<int, int>(9, 11), new Tuple<int, int>(7, 9) };
            var target = 18;
            var result = GetMaxSumWithinTheTarget.GetSumDP(arr, target);
            Assert.AreEqual(result, 15);
        }

        [TestMethod]
        public void GetMaxSumWithinTheTarget_Test4DP()
        {
            Tuple<int, int>[] arr = { new Tuple<int, int>(5, 7), new Tuple<int, int>(1, 2),
                new Tuple<int, int>(8, 9), new Tuple<int, int>(9, 11), new Tuple<int, int>(4, 6) };
            var target = 20;
            var result = GetMaxSumWithinTheTarget.GetSumDP(arr, target);
            Assert.AreEqual(result, 17);
        }
    }
}
