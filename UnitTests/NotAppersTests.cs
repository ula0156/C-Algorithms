using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Array;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class NotAppersTests
    {
        [TestMethod]
        public void NotAppersTests1()
        {
            int[] a = { 4, 3, 2, 7, 8, 2, 3, 1 };
            var result = NotAppears.FindDisappearedNumbers(a);
            CollectionAssert.AreEqual(result, new List<int> { 5, 6 });
        }
    }
}
