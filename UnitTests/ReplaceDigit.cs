using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.MockInterviews;

namespace UnitTests
{
    [TestClass]
    public class ReplaceDigitTests
    {
        [TestMethod]
        public void ReplaceDigit_SingleOccurrence1()
        {
            var result = ReplaceDigit.SingleOccurrence(234, 3, 6);
            Assert.AreEqual(result, 264);
        }

        [TestMethod]
        public void ReplaceDigit_MultipleOccurrence()
        {
            var result = ReplaceDigit.MultipleOccurrence(23432, 3, 6);
            Assert.AreEqual(result, 26462);
        }

    }
}
