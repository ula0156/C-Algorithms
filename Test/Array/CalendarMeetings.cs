using System;
using System.Collections.Generic;

namespace Test.Array
{
    public class MergingRanges
    {
        private static void _SortArray(int[][] a, int[] sortedArrayStartTime, int[] sortedArrayEndTime)
        {
            for (var i = 0; i < sortedArrayStartTime.Length; i++)
            {
                sortedArrayStartTime[i] = -1;
                sortedArrayEndTime[i] = -1;
            }

            for (var j = 0; j < a.Length; j++)
            {
                if (sortedArrayEndTime[a[j][0]] < a[j][1])
                {
                    sortedArrayEndTime[a[j][0]] = a[j][1];
                }

                sortedArrayStartTime[a[j][0]]= a[j][0];
            }
        }

        public static List<int[]> MergeRanges(int[][] meetings)
        {
            int[] overlapMeeting = new int[2];
            List<int[]> result = new List<int[]>();
            int[] sortedArrayStartTime = new int [25];
            int[] sortedArrayEndTime = new int[25];
            _SortArray(meetings, sortedArrayStartTime, sortedArrayEndTime);

            var i = 0;
            var strTime = sortedArrayStartTime[i];
            var endTime = sortedArrayEndTime[i];
            var isSlotFound = false;
            for (; i < sortedArrayStartTime.Length; i++)
            {
                if (sortedArrayStartTime[i] > -1)
                {
                    if (endTime >= sortedArrayStartTime[i] && isSlotFound)
                    {
                        endTime = Math.Max(endTime, sortedArrayEndTime[i]);
                    }

                    else if (!isSlotFound)
                    {
                        isSlotFound = true;
                        strTime = sortedArrayStartTime[i];
                        endTime = sortedArrayEndTime[i];
                    }
                    else if (isSlotFound)
                    {
                        result.Add(new int[] { strTime, endTime});
                        strTime = sortedArrayStartTime[i];
                        endTime = sortedArrayEndTime[i];
                    }
                }
            }

            if (isSlotFound)
            {
                result.Add(new int[] { strTime, endTime });
            }

            return result;
        }
    }
}