using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;

namespace UnitTests
{
    [TestClass]
    public class IsPalindromeTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string s = "weeckeew";
            bool result = IsPalindrome.IsStringPalindrome(s);
            Assert.AreEqual(result, false);

        }
        [TestMethod]
        public void TestMethod2()
        {
            string s = "weeceew";
            bool result = IsPalindrome.IsStringPalindrome(s);
            Assert.AreEqual(result, true);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string s = "w";
            bool result = IsPalindrome.IsStringPalindrome(s);
            Assert.AreEqual(result, true);
        }
        [TestMethod]
        public void TestMethod4()
        {
            string s = " ";
            bool result = IsPalindrome.IsStringPalindrome(s);
            Assert.AreEqual(result, true);
        }
        [TestMethod]
        public void TestMethod5()
        {
            string s = "wc";
            bool result = IsPalindrome.IsStringPalindrome(s);
            Assert.AreEqual(result, false);
        }
    }
}
