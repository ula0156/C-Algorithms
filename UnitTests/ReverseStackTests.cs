using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Stack;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class ReverseStackTests
    {
        [TestMethod]
        public void ReverseStack1()
        {
            var stack = new Stack<int>();
            var n = 4;
            while (n > 0)
            {
                stack.Push(n);
                n--;
            }

            ReverseStack.ReverseAStack2(stack);
            CollectionAssert.AreEqual(stack, new Stack<int> (new int[] { 1, 2, 3, 4 }));
        }
    }
}
