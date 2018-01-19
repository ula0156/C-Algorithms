using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.DynamicProgramming;

namespace UnitTests
{
    [TestClass]
    public class KnapsackProblemTests
    {
        [TestMethod]
        public void KnapsackProblem_Test1()
        {
            int[] val = { 7, 10, 15 };
            int[] weight = { 3, 5, 6 };
            int target = 9;
            var result = KnapsackProblem.GetMaxValue(val, weight, target);
            Assert.AreEqual(result, 22);
        }

        [TestMethod]
        public void KnapsackProblem_Test2()
        {
            int[] val = { 7, 10, 15, 7 };
            int[] weight = { 3, 5, 7, 4 };
            int target = 32;
            var result = KnapsackProblem.GetMaxValue(val, weight, target);
            Assert.AreEqual(result, 73);
        }

        [TestMethod]
        public void KnapsackProblem_Test3()
        {
            int[] val = { 160, 90, 15 };
            int[] weight = { 7, 3, 2 }; 
            int target = 20;
            var result = KnapsackProblem.GetMaxValue(val, weight, target);
            Assert.AreEqual(result, 555);
        }

        [TestMethod]
        public void KnapsackProblem_Test4()
        {
            int[] val = { 160, 90, 15 };
            int[] weight = { 7, 3, 2 };
            int target = 20;
            var result = KnapsackProblem.GetMaxValue2(val, weight, target);
            Assert.AreEqual(result, 555);

            var x = 0;
        }
    }
}
