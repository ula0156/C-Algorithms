using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.MockInterviews
{
    public class PascalTriangle
    {
        public static int[][] CreatePascalTiangle(int n)
        {
            var triangle = new int[n][];
            triangle[0] = new int[] { 1 };
            triangle[1] = new int[] { 1, 1 };
            
            var i = 2;
            while(i < n)
            {
                var row = new int[i + 1];
                var col = 0;
                while(col < row.Length)
                {
                    if (col == 0 || col == row.Length - 1)
                    {
                        row[col] = 1;
                    } else
                    {
                        row[col] = triangle[i - 1][col - 1] + triangle[i - 1][col];
                    }
                    col++;
                }
                triangle[i] = row;
                i++;
            }

            return triangle;
        } 
    }
}
