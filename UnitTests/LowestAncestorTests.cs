using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.trees;
using System.Collections.Generic;
using Test.Trees;
using Test;

namespace UnitTests
{
    [TestClass]
    public class LowestAncestorTests
    {
        [TestMethod]
        public void LowestAncestor_test1()
        {
            int[] a = { 7, 1, 3, 6, 4, 12, 33, 57, 9, 0 };
            var list = new List<int>();
            foreach (var item in a)
            {
                list.Add(item);
            }
            
            var root = TreeUtils.CreateBalancedBinaryTreeFromArray(list);
            var result = LowestAncestor.GetAncestor(root, 57, 33);
            Assert.AreEqual(new Node(4), result);
        }

        [TestMethod]
        public void LowestAncestor_test2()
        {
            int[] a = { 7, 1, 3, 6, 4, 12, 33, 57, 9, 0 };
            var list = new List<int>();
            foreach (var item in a)
            {
                list.Add(item);
            }

            var root = TreeUtils.CreateBalancedBinaryTreeFromArray(list);
            var result = LowestAncestor.LowestCommonAncestor(root, 1, 7);
            Assert.AreEqual(1, result);
        }
    }
}
