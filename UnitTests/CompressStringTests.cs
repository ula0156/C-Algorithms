using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GreenBook.StringAndArray;

namespace UnitTests
{
    [TestClass]
    public class CompressStringTests
    {
        [TestMethod]
        public void StringCompression1()
        {
            var s = "aaaabbbccctt";
            var result = StringCompression.CompressString(s);
            Assert.AreEqual("a4b3c3t2", result);
        }

        [TestMethod]
        public void StringCompression2()
        {
            var s = "abbbccctt";
            var result = StringCompression.CompressString(s);
            Assert.AreEqual("a1b3c3t2", result);
        }

        [TestMethod]
        public void StringCompression3()
        {
            var s = "abcc";
            var result = StringCompression.CompressString(s);
            Assert.AreEqual("abcc", result);
        }

        [TestMethod]
        public void StringCommpressionTrue()
        {
            var s = "aa";
            var result = StringCompression.CompressString(s);
            Assert.AreEqual("aa", result);
        }
    }
}
