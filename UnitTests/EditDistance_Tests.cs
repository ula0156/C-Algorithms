using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Matrix;

namespace UnitTests
{
    [TestClass]
    public class EditDistance_Tests
    {
        [TestMethod]
        public void EditDistance_Test_1()
        {
            var s1 = "a";
            var s2 = "ab";
            var result = EditDistance.MinDistance(s1, s2);
            Assert.AreEqual(result, 1);
        }
    }
}
