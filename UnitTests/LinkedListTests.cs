using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test;
using System.Collections.Generic;
using Test.List;

namespace UnitTests
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod] 
        public void _CloneLLWithRandomPointer()
        {
            int[] items = new int[] { 1, 2, 3, 4, 5 };
            NodeLinkedList head = LinkedListUtils.CreateLinkedList(items);
            NodeLinkedList head2 = CloneLinkedListWithRandomPointers._cloneLL(head);
            Assert.AreEqual(head2.Data, 1);
        }

        [TestMethod]
        public void _CloneLLWithRandomPointerWithAdditionalDataStructure()
        {
            int[] items = new int[] { 1, 2, 3, 4, 5 };
            NodeLinkedList head = LinkedListUtils.CreateLinkedList(items);
            NodeLinkedList head2 = CloneLLWithRPAdditionalDS._CloneLLWithRPAdditionalDS(head);
            Assert.AreEqual(head2.Data, 1);
        }

        [TestMethod]
        public void IsPalindrome_OddLength()
        {
            char[] items = new char[] { 'a', 'b', 'a'};
            NodeLinkedList head = LinkedListUtils.CreateLinkedListChar(items);
            bool result = IsLinkedListPalindrome._IsLinkedListPalindrome2(head);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindrome_EvenLength()
        {
            char[] items = new char[] { 'a', 'b', 'b', 'a' };
            NodeLinkedList head = LinkedListUtils.CreateLinkedListChar(items);
            bool result = IsLinkedListPalindrome._IsLinkedListPalindrome2(head);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindrome_OnlyElement()
        {
            char[] items = new char[] { 'a' };
            NodeLinkedList head = LinkedListUtils.CreateLinkedListChar(items);
            bool result = IsLinkedListPalindrome._IsLinkedListPalindrome2(head);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindrome_EvenFalse()
        {
            char[] items = new char[] { 'a', 'b' };
            NodeLinkedList head = LinkedListUtils.CreateLinkedListChar(items);
            bool result = IsLinkedListPalindrome._IsLinkedListPalindrome2(head);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsPalindrome_OddFalse()
        {
            char[] items = new char[] { 'a', 'b', 'c' };
            NodeLinkedList head = LinkedListUtils.CreateLinkedListChar(items);
            bool result = IsLinkedListPalindrome._IsLinkedListPalindrome2(head);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void RemoveDup_oneDup()
        {
            char[] items = new char[] { 'a', 'b', 'c', 'b', 'k' };
            NodeLinkedList head = LinkedListUtils.CreateLinkedListChar(items);
            NodeLinkedList result = RemoveDupFromLL._RemoveDupFromLL(head);
            Assert.AreEqual(result, head);
        }
        
        [TestMethod]
        public void NewLL_SumOfTow()
        {
            int[] a = new int[] { 1 };
            int[] b = new int[] { 9999, 9999 };
            NodeLinkedList head1 = LinkedListUtils.CreateLinkedList(a);
            NodeLinkedList head2 = LinkedListUtils.CreateLinkedList(b);

            NodeLinkedList result = SumLinkedListsValues.GetNewLinkedList(head1, head2);
            Assert.AreEqual(result.Data, 1);
        }
    }
}
