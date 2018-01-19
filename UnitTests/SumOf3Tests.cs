using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.LeetCode;

namespace UnitTests
{
    [TestClass]
    public class SumOf3Tests
    {
        [TestMethod]
        public void SumOf3_Test1()
        {
            int[] a = { -1, 0, 1, 2, -1, -4 };
            SumOf3.ThreeSum(a);
            var x = 0;
        }

        [TestMethod]
        public void SumOf3_Test2()
        {
            int[] a = { 0, 0, 0, 0 };
            SumOf3.ThreeSum(a);
            var x = 0;
        }

        
    }
}
