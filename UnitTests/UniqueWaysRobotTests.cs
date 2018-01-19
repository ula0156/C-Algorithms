using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.LeetCode;

namespace UnitTests
{
    [TestClass]
    public class UniqueWaysRobotTests
    {
        [TestMethod]
        public void UniqueWaysRobot_Test1()
        {
            var mat = new int[2,2];
            var result = UniqueWaysRobot.GetPath(mat, 0, 0, 1, 1);
            Assert.AreEqual(2, result);
        }
    }
}
