using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Array;

namespace UnitTests
{
    [TestClass]
    public class DutchFlagTests
    {
        [TestMethod]
        public void DutchFlagTest_1()
        {
            int[] a = { 2, 2, 2, 1, 0, 1, 1, 2, 0 };
            DutchFlagProblem.Sort(a);
        }

        [TestMethod]
        public void DutchFlagTest_2()
        {
            int[] a = { 1, 1, 2, 0, 0, 1, 0 };
            DutchFlagProblem.Sort(a);

            var x = 0;
        }
    }
}
