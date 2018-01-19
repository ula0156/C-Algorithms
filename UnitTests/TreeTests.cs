using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;
using System.Collections.Generic;
using Test.trees;
using Test;
using Test.Trees;

namespace UnitTests
{
    [TestClass]
    public class TreeTests
    {
        [TestMethod]
        public void Test_TryFindMinWithOutParameter()
        {
            List<int> items = new List<int> { 1, 2, 3, 4, 5, 6 };
            var root = TreeUtils.CreateBalancedBinaryTreeFromArray(items);
            int minValue;
            Assert.IsTrue(TryToFindMinRecusivly.TryFindMin(root, out minValue));
            Assert.AreEqual(minValue, 1);
        }

        [TestMethod]
        public void Test_TryFindMinWithTuple()
        {
            List<int> items = new List<int> { 1, 2, 3, 4, 5, 6 };
            var root = TreeUtils.CreateBalancedBinaryTreeFromArray(items);
            Assert.IsTrue(TryToFindMin.TryFindMin(root).Item1);
            Assert.AreEqual(TryToFindMin.TryFindMin(root).Item2, 1);
        }

        [TestMethod]
        public void Test_IsBST()    
        {
            List<int> items = new List<int> { 1, 2, 3, 4, 5, 6 };
            var root = TreeUtils.CreateBalancedBinaryTreeFromArray(items);
            Assert.IsTrue(IsBinarySearchTree.IsBST(root));
        }

        [TestMethod]
        public void Test_minSum()   
        {
            List<int> items = new List<int> { 1, 2, 3, 4, 5, 6 };
            var root = TreeUtils.CreateBalancedBinaryTreeFromArray(items);
            Assert.AreEqual(MinSum.minSum(root), 6);
        }

        [TestMethod]
        public void FindTarget()
        {
            List<int> items = new List<int> { 1 };
            var root = TreeUtils.CreateBalancedBinaryTreeFromArray(items);
            var result = SumToKth.FindTarget(root, 2);
            Assert.IsTrue(result);
            
        }

        [TestMethod]
        public void Test_FindMinAndMax()
        {
            List<int> items = new List<int> { 1, 2, 3, 4, 5, 6 };
            var root = TreeUtils.CreateBalancedBinaryTreeFromArray(items);
            int max;
            Assert.AreEqual(FindMinAndMax._findMinAndMax(root, out max), 1);
            Assert.AreEqual(max, 6);
        }
        
        [TestMethod]
        public void Test_IsWeighted()
        {
            List<int> items = new List<int> { 2, 2, 3, 7, 1, 5, 1 };
            var root = TreeUtils.CreateBalancedBinaryTreeFromArray(items);
            int sum;
            Assert.IsTrue(IsWeighted.isWeighted(root, out sum));
            Assert.AreEqual(sum, 21);
        }

        [TestMethod]
        public void Test_BreadthFirstTraversal1()
        {
            List<int> items = new List<int> { 2, 2, 3, 7, 1, 5, 1 };
            var root = TreeUtils.CreateBalancedBinaryTreeFromArray(items);
            var result = BreadthFirstTraversal.AverageOfLevels(root);
        }
    }
}
