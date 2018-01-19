using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.LeetCode
{
    public class UniqueWaysRobot
    {
        public static int GetPath(int[,] mat, int r, int c, int m, int n)
        {
            if (r == m || c == n)
            {
                return 0;
            }

            if (r == m && c == n)
            {
                return 1;
            }

            return GetPath(mat, r + 1, c, m, n) + GetPath(mat, r, c + 1, m, n);
        }
    }
}
