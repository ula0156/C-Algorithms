using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.LeetCode;

namespace UnitTests
{
    [TestClass]
    public class RotatedStringArrayTests
    {
        [TestMethod]
        public void RotatedStringArray_Test1()
        {
            var words = new string[]
            {
                "ptolemaic",
                "retrograde",
                "supplant",
                "undulate",
                "xenoepist",
                "asymptote",  // <-- rotates here!
                "babka",
                "banoffee",
                "engender",
                "karpatka",
                "othellolagkage",
            };
            var index = RotatedStringArray.FindRotatedIndex(words);
            Assert.AreEqual(4, index);
        }
    }
}
