using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class MatrixUtils
    {
        public static void PrintMatrix(int[][] matrix)
        {
            for (var i = 0; i < matrix.Length; i++)
            {
                for (var j = 0; j < matrix[i].Length; j++)
                {
                    Debug.Write(matrix[i][j] == 0 ? "0" : "1");
                }

                Debug.WriteLine("");
            }
        }

        public static int[][] Matrix(int n, int m)
        {
            int[][] mat = new int[n][];
            for (var i = 0; i < n; i++)
            {
                mat[i] = new int[m];
            }

            return mat;
        }

        public static void FillMatrix(int[][] matrix, int n, int m)
        {
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    if (j%2 == 0)
                    {
                        matrix[i][j] = 0;

                    }
                    else
                    {
                        matrix[i][j] = 1;
                    }
                }
            }
        }
    }
}
