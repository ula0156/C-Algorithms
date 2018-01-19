using System;

namespace Test.Trees
{
    class SecondSmallestSpecialTree
    {
        private static int FindSmallest(Node n, int val)
        {
            if (n.Data != val)
            {
                return n.Data;
            }
            if (n.Left == null)
            {
                return -1;
            }

            var minLeft = FindSmallest(n.Left, val);
            var minRight = FindSmallest(n.Right, val);

            if (minLeft != -1 && minRight != -1)
            {
                return Math.Min(minRight, minLeft);
            }

            if (minLeft != -1)
            {
                return minLeft;
            }
            if (minRight != -1)
            {
                return minRight;
            }

            return -1;
        }

        public static int FindSecondSmallest(Node n)
        {
            return FindSmallest(n, n.Data);
        }
    }
}
