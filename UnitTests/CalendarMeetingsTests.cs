using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Array;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class CalendarMeetingsTests
    {
        private static bool AreSame(List<int[]> actual, List<int[]> expected)
        {
            if (actual.Count != expected.Count)
                return false;

            for (var i = 0; i < actual.Count; i++)
            {
                if (actual[i].Length != expected[i].Length)
                {
                    return false;
                }

                for (var j = 0; j < actual[i].Length; j++)
                {
                    if (actual[i][j] != expected[i][j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        [TestMethod]
        public void CalendarMeetingsTests1()
        {
            int[][] meetings = new int[][] {
                 new int[] { 9, 12 },  new int[] { 3, 9 }, new int[] { 0, 1 }
            };
            var result = MergingRanges.MergeRanges(meetings);
            Assert.IsTrue(AreSame(result, new List<int[]>() { new int[] { 0, 1 }, new int[] { 3, 12 } }));
        }


        [TestMethod]
        public void CalendarMeetingsTests2()
        {
            int[][] meetings = new int[][] {
                new int[] { 0, 1 }, new int[] { 4, 8 }, new int[] { 3, 5 }, new int[] { 10, 12 },
                new int[] { 9, 10 }
            };
            var result = MergingRanges.MergeRanges(meetings);
            Assert.IsTrue(AreSame(result, new List<int[]>() { new int[] { 0, 1 }, new int[] { 3, 8 }, new int[] { 9, 12} }));
        }


        [TestMethod]
        public void CalendarMeetingsTests3()
        {
            int[][] meetings = new int[][] {
                new int[] { 1, 2 }, new int[] { 2, 3 }
            };
            var result = MergingRanges.MergeRanges(meetings);
            Assert.IsTrue(AreSame(result, new List<int[]>() { new int[] { 1, 3 } }));
        }

        [TestMethod]
        public void CalendarMeetingsTests4()
        {
            int[][] meetings = new int[][] {
                new int[] { 3, 5 }, new int[] { 7, 9 }, new int[] { 2, 6 }, new int[] { 1, 10 }
            };
            var result = MergingRanges.MergeRanges(meetings);
            Assert.IsTrue(AreSame(result, new List<int[]>() { new int[] { 1, 10 } }));
        }
    }
}
