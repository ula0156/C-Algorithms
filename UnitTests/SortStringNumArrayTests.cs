using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GreenBook.StringAndArray;

namespace UnitTests
{
    [TestClass]
    public class SortStringNumArrayTests
    {
        [TestMethod]
        public void SortStringNumArray_Test1()
        {
            string[] a = { "6", "31415926535897932384626433832795", "1", "3", "10", "3", "5" };
            SortStringNumArray.Sort(a);
            var x = 0;
        }

        [TestMethod]
        public void SortStringNumArray_Test2()
        {
            string[] a = { "6", "0", "1", "2", "8" };
            SortStringNumArray.Sort(a);
            var y = 0;
        }

        [TestMethod]
        public void SortStringNumArray_Test3()
        {
            string[] a = { "4", "7", "1", "8", "3" };
            SortStringNumArray.Sort(a);
            var y = 0;
        }

        [TestMethod]
        public void SortStringNumArray_Test4()
        {
            string[] a = { "1324567890987565", "1324567890987564", "8888", "31", "3" };
            SortStringNumArray.Sort(a);
            var y = 0;
        }

        [TestMethod]
        public void SortStringNumArray_Test5()
        {
            string[] a = { "3", "0" };
            SortStringNumArray.Sort(a);
            var y = 0;
        }
    }
}