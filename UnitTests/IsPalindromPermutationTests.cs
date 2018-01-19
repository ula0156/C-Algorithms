
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GreenBook.StringAndArray;

namespace UnitTests
{
    [TestClass]
    public class IsPalindromPermutationTests
    {
        [TestMethod]
        public void PalindromePermutationTrue()
        {
            var s = "Tact Coa";
            var result = IsPalindromePermutation._IsPalindromePermutation(s);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void PalindromePermutationFalse()
        {
            var s = "Tak k";
            var result = IsPalindromePermutation._IsPalindromePermutation(s);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void PalindromePermutationOneChar()
        {
            var s = "T";
            var result = IsPalindromePermutation._IsPalindromePermutation(s);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void PalindromePermutation5SameChar()
        {
            var s = "ababa";
            var result = IsPalindromePermutation._IsPalindromePermutation(s);
            Assert.IsTrue(result);
        }
    }
}
