using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Recusion
{
    public class RobotMinDistance
    {
       public static int FindRobotMinDistance(int[][] matrix, int i, int j)
        {
            if (i == matrix.Length || j == matrix[i].Length || matrix[i][j] == 5)
            {
                return -1;
            }
            if (matrix[i][j] == 10)
            {
                return 0;
            }
            var right = FindRobotMinDistance(matrix, i, j + 1);
            var down = FindRobotMinDistance(matrix, i + 1, j);
            if (right == -1 && down == -1)
            {
                return -1;
            }
            else if (right == -1)
            {
                return 1 + down;
            }
            else if (down == -1)
            {
                return 1 + right;
            }

            return Math.Min(right, down);
        }
    }
}
