using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test;
using Test.trees;
using Test.Trees;

namespace UnitTests
{
    [TestClass]
    public class ConvertBSTToDLLTests
    {
        [TestMethod]
        public void ConvertBSTToDLL_Method1()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            var list = new List<int>();
            foreach (var item in arr)
            {
                list.Add(item);
            }

            Node root =TreeUtils.CreateBalancedBinaryTreeFromArray(list);
            var result = ConvertBSTToDLL.ConvertBSTToDoubleLinkList(root);

            var x = 0;
        }
    }
}
