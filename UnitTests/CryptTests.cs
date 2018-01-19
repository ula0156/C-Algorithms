using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Array;

namespace UnitTests
{
    [TestClass]
    public class CryptTests
    {
        [TestMethod]
        public void Crypt_test1()
        {
            char[][] solution = {
            new char[] {'O', '0' },
            new char[] { 'M', '1'},
            new char[] { 'Y', '2'},
            new char[] { 'E', '5'},
            new char[] { 'N', '6'},
            new char[] { 'D', '7'},
            new char[] { 'R', '8'},
            new char[] { 'S', '9'}};

            string[] crypt = { "SEND", "MORE", "MONEY" };

            var result = Crypt.isCryptSolution(crypt, solution);
            Assert.AreEqual(result, true);
        }
    }
}
