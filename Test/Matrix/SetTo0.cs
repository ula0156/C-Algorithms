using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Matrix
{
    public static class SetTo0
    {
        private static void addValueToSet(int k, HashSet<int> set)
        {
            if (!set.Contains(k))
            {
                set.Add(k);
            }
        }
        

        private static void setRowValuesTo0(int[][] mat, HashSet<int> rowSet)
        {
            foreach (int rowIndex in rowSet)
            {
                for (var j = 0; j < mat[0].Length; j++)
                {
                    mat[rowIndex][j] = 0;
                }
            }
        }

        private static void setColomnValuesTo0(int[][] mat, HashSet<int> colomnSet)
        {
            foreach (int colIndex in colomnSet)
            {
                for (var i = 0; i < mat.Length; i++)
                {
                    mat[i][colIndex] = 0;
                }
            }
        }


        public static void _SetTo0(int[][] mat, int n, int m)
        {
            HashSet<int> rowSet = new HashSet<int>();
            HashSet<int> colomnSet = new HashSet<int>();

            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    if (mat[i][j] == 0)
                    {
                        addValueToSet(i, rowSet);
                        addValueToSet(j, colomnSet);
                    }
                    
                }
            }

            setRowValuesTo0(mat, rowSet);
            setColomnValuesTo0(mat, colomnSet);

        }
    }
}
