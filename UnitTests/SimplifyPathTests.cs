using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Strings;

namespace UnitTests
{
    [TestClass]
    public class SimplifyPathTests
    {
        [TestMethod]
        public void SimplifyPath_test1()
        {
            var s = "/jk/jk///kjfh/..";
            var result = SimplifyPath.TrySimplifyPath(s);
            var x = 0;
        }

        [TestMethod]
        public void SimplifyPath_test2()
        {
            var s = "/.";
            var result = SimplifyPath.TrySimplifyPath(s);
            var x = 0;
        }
    }
}
