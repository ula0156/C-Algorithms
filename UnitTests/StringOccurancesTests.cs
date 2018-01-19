using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Strings;

namespace UnitTests
{
    [TestClass]
    public class StringOccurancesTests
    {
        [TestMethod]
        public void StringOccurances_Test1()
        {
            var s2 = "abcd";
            var s1 = "cdabcdab";
            var result = StringOccurances.GetOccurance(s1, s2);
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void StringOccurances_Test2()
        {
            var s2 = "";
            var s1 = "";
            var result = StringOccurances.GetOccurance(s1, s2);
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void StringOccurances_Test3()
        {
            var s2 = "abcd";
            var s1 = "cdkabc";
            var result = StringOccurances.GetOccurance(s1, s2);
            Assert.AreEqual(result, 1);
        }
    }
}
