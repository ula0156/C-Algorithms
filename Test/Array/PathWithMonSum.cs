using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Array
{
    public class PathWithMinSum
    {
        public static int GetMinSum(int[][] mat)
        {
            for (var row = mat.Length - 2; row >= 0; row--)
            {
                for (var col = 0; col < mat[row].Length; col++)
                {
                    mat[row][col] = mat[row][col] + Math.Min(mat[row + 1][col], mat[row + 1][col + 1]);
                }
            }

            return mat[0][0];
        }


        public static int GetMinSumRecusive(int[][] mat, int row, int col) 
        {
            if (row == mat.Length)
            {
                return 0;
            }

            return mat[row][col] + Math.Min(GetMinSumRecusive(mat, row + 1, col) , GetMinSumRecusive(mat, row + 1, col + 1));
        }
    }
}
