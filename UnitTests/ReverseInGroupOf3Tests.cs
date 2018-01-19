using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.LinkedList;
using Test.List;

namespace UnitTests
{
    [TestClass]
    public class ReverseInGroupOfKTests
    {
        [TestMethod]
        public void ReverseInGroupOfK_Test1()
        {
            var arr = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
            var head = LinkedListUtils.CreateLinkedList(arr);
            var result = ReverseInGroupOfK.ReverseByGroup(head, 3);

            var x = 0;
        }
    }
}
