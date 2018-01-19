using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Heap;

namespace UnitTests
{
    [TestClass]
    public class GetTotalTimeToExecuteTests
    {
        [TestMethod]
        public void GetTotalTimeToExecute_Tests1()
        {
            int[] arr = { 1,5,6,1,1,2,2,0,2,6,1 };
            var k = 2;
            var result = GetTotalTimeToExecute.GetTime(arr, k);
            Assert.AreEqual(result, 11);
        }

        [TestMethod]
        public void GetTotalTimeToExecute_Tests2()
        {
            int[] arr = { 1, 2, 1, 3, 2, 1 };
            var k = 3;
            var result = GetTotalTimeToExecute.GetTime(arr, k);
            Assert.AreEqual(result, 10);
        }
    }
}
