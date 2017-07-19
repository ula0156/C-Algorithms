using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class TestFindMinDistance
    {
        [TestMethod]
        public void Test_FindMinDistance()
        {
            List<Tuple<int, int, int>> distance = new List<Tuple<int, int, int>>();
            distance.Add(new Tuple<int, int, int>(7, 5, 8));
            distance.Add(new Tuple<int, int, int>(13, 2, 7));
            distance.Add(new Tuple<int, int, int>(9, 0, 3));
            Assert.AreEqual(FindMinDistance.GetMinDistance(distance, 0), 18);
        }
    }
}
