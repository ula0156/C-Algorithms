using Test.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class FirstMissingTests
    {
        [TestMethod]
        public void FirstMissingTests1()
        {
            int[] a = { 1, 2, 0 };
            var result = FirstMissing.FirstMissingPositive(a);
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void FirstMissingTests2()
        {
            int[] a = { 3, 4,- 1, 1 };
            var result = FirstMissing.FirstMissingPositive(a);
            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void FirstMissingTests_1Element()
        {
            int[] a = { 2 };
            var result = FirstMissing.FirstMissingPositive(a);
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void FirstMissingTests_1Element_0()
        {
            int[] a = { 0 };
            var result = FirstMissing.FirstMissingPositive(a);
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void FirstMissingTests_3()
        {
            int[] a = { 1, 0 };
            var result = FirstMissing.FirstMissingPositive(a);
            Assert.AreEqual(result, 2);
        }
    }
}
