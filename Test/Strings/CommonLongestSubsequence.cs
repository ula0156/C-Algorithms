using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Strings
{
    public class CommonLongestSubsequence
    {
        // Given two string str1 and str2, find the shortest string that has both str1 and str2 as subsequences.
        //Examples:
        //Input: str1 = “geek”, str2=”eke”
        //Output: “geeke”
        //Input: str1 = “AGGTAB”, str2=”GXTXAYB”
        //Output: “AGXGTXAYB”
        private static string GetShortestString(string s1, string s2, StringBuilder subsequence)
        {
            var result = new StringBuilder();
            var sPointer = 0;
            var pointerS1 = s1.Length - 1;
            var pointerS2 = s2.Length - 1;

            while (sPointer < subsequence.Length)
            {
                if (subsequence[sPointer] == s1[pointerS1] && subsequence[sPointer] == s2[pointerS2])
                {
                    result.Append(subsequence[sPointer]);
                    sPointer++;
                    pointerS1--;
                    pointerS2--;
                }
                if (subsequence[sPointer] == s1[pointerS1] && subsequence[sPointer] != s2[pointerS2])
                {
                    result.Append(s2[pointerS2]);
                    pointerS2--;
                }
                if (subsequence[sPointer] != s1[pointerS1] && subsequence[sPointer] == s2[pointerS2])
                {
                    result.Append(s1[pointerS1]);
                    pointerS1--;
                }
            }
            while (pointerS1 >= 0)
            {
                result.Append(s1[pointerS1]);
                pointerS1--;
            }

            while (pointerS2 >= 0)
            {
                result.Append(s2[pointerS2]);
                pointerS1--;
            }

            // should reverse a string!!
            return result.ToString();
        }

        private static StringBuilder GetSubSequence(int[][] mat, int p1, int p2, string s1, string s2, StringBuilder subSequence)
        {
            if (mat[p1][p2] == 0)
            {
                return subSequence;
            }

            if (s1[p1] == s2[p2])
            {
                subSequence.Append(s1[p1]);
                return GetSubSequence(mat, p1 - 1, p2 - 1, s1, s2, subSequence);
            }

            if (mat[p1][p2] > mat[p1][p2])
            {
                return GetSubSequence(mat, p1 - 1, p2, s1, s2, subSequence);
            }

            return GetSubSequence(mat, p1, p2 - 1, s1, s2, subSequence);
        }

        private static void FillMat(int[][] mat, string s1, string s2, int n, int m)
        {
            for (int j = 1; j < n; j++)
            {
                for (int k = 1; k < m; k++)
                {
                    if (s1[j - 1] == s2[k - 1])
                    {
                        mat[j][k] = mat[j - 1][k - 1] + 1;
                    }
                    else
                    {
                        mat[j][k] = Math.Max(mat[j - 1][k], mat[j][k - 1]);
                    }
                }
            }
        }

        private static string CreateMatrix(string s1, string s2)
        {
            var n = Math.Max(s1.Length + 1, s2.Length + 1);
            var m = Math.Min(s1.Length + 1, s2.Length + 1);

            var row = n >= m ? new int[n][] : new int[m][];
            for (int i = 0; i < row.Length; i++)
            {
                row[i] = new int[m];
            }

            FillMat(row, s1, s2, n, m);

            var subSequence = new StringBuilder();
            var sequence = GetSubSequence(row, s1.Length, s2.Length, s1, s2, subSequence);

            return GetShortestString(s1, s2, subSequence);
        }

        public static string ShortestString(string s1, string s2)
        {
            return CreateMatrix(s1, s2);
        }

    }
}
