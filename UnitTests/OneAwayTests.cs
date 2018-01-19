using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GreenBook.StringAndArray;

namespace UnitTests
{
    [TestClass]
    public class OneAwayTests
    {
        [TestMethod]
        public void OneAway_Order()
        {
            var s1 = "abc";
            var s2 = "cba";
            var result = OneAway._OneAway(s1, s2);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void OneAway_Insert()
        {
            var s1 = "pale";
            var s2 = "ple";
            var result = OneAway._OneAway(s1, s2);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void OneAway_False()
        {
            var s1 = "pale";
            var s2 = "plebe";
            var result = OneAway._OneAway(s1, s2);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void OneAway_Delete()
        {
            var s1 = "pale";
            var s2 = "palek";
            var result = OneAway._OneAway(s1, s2);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void OneAway_Change()
        {
            var s1 = "pale";
            var s2 = "pele";
            var result = OneAway._OneAway(s1, s2);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void OneAway_Delete2()
        {
            var s1 = "pale";
            var s2 = "peleeeee";
            var result = OneAway._OneAway(s1, s2);
            Assert.IsFalse(result);
        }
    }
}
