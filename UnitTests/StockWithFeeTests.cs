using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Array;

namespace UnitTests
{
    [TestClass]
    public class StockWithFeeTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = new int[] { 1, 3, 7, 5, 10, 3 };
 
            var fee = 3;
            var result = StockWithFee.MaxProfit(a, fee);
        }

        
    }
}
