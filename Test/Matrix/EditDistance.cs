using System;

namespace Test.Matrix
{
    public class EditDistance
    {
        private static int[][] FillMatrix(string word1, string word2)
        {
            int[][] mat = new int[word2.Length + 1][];
            for (var i = 0; i < mat.Length; i++)
            {
                mat[i] = new int[word1.Length + 1];
            }

            var r = 0;
                for (var j = 0; j < mat[r].Length; j++)
                {
                    mat[r][j] = j;
                }

            for (r = 0; r < mat.Length; r++)
            {
                var j = 0;
                {
                    mat[r][j] = r;
                }
            }
            return mat;
        }
        public static int MinDistance(string word1, string word2)
        {
            if (word1 == "" && word2 == "")
            {
                return 0;
            }
            if (word1 == "")
            {
                return word2.Length - 1;
            }
            if (word2 == "")
            {
                return word1.Length - 1;
            }

            var mat = FillMatrix(word1, word2);
            for (var r = 1; r < mat.Length; r++)
            {
                for (var c = 1; c < mat[r].Length; c++)
                {
                    if (word2[r - 1] == word1[c - 1])
                    {
                        mat[r][c] = mat[r - 1][c - 1];
                    } else
                    {
                        mat[r][c] = (Math.Min(mat[r - 1][c], Math.Min(mat[r - 1][c - 1], mat[r][c - 1])) + 1);
                    }
                }
            }

            return mat[mat.Length - 1][mat[0].Length - 1];
        }
    }
}
