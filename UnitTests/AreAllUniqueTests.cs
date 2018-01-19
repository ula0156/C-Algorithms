using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GreenBook.StringAndArray;

namespace UnitTests
{
    [TestClass]
    public class AreAllUniqueTests
    {
        [TestMethod]
        public void NotUnique()
        {
            string s = "abdea";
            var result = AreAllUnique.AreUnique(s);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void NotUniqueNoAdditionalMemory()
        {
            string s = "abdea";
            var result = AreAllUnique.AreUnique2(s);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AreUnique()
        {
            string s = "abde";
            var result = AreAllUnique.AreUnique(s);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AreUniqueNoAdditionalMemory()
        {
            string s = "abd";
            var result = AreAllUnique.AreUnique2(s);
            Assert.IsTrue(result);
        }
    }
}
