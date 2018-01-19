using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Trees
{
    public class SumToKth
    {
        private static void Traverse(Node n, List<int> arr)
        {
            if (n == null)
            {
                return;
            }
            Traverse(n.Left, arr);
            arr.Add(n.Data);
            Traverse(n.Right, arr);
        }
        public static bool FindTarget(Node n, int k)
        {
            var arr = new List<int>();
            Traverse(n, arr);
            var p1 = 0;
            var p2 = arr.Count - 1;

            while (p1 < p2)
            {
                if ((arr[p1] + arr[p2]) > k)
                {
                    p2--;
                }
                else if (arr[p1] + arr[p2] < k)
                {
                    p1++;
                }
                else if (arr[p1] + arr[p2] == k)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
