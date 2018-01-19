namespace Test.Recusion
{
    public class NumberOfObjects
    {
        public static int _NumberOfObjects(int[][]mat, int n, int m)
        {
            int numOfObj = 0;
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    if (mat[i][j] == 1)
                    {
                        numOfObj++;
                        ClearMatrix(mat, i, j, n, m);
                    }
                }
            }

            return numOfObj;
        }

        private static void ClearMatrix(int[][] mat, int i, int j, int n, int m)
        {
            if (i == n || j == m || i < 0|| j < 0 || mat[i][j] == 0)
            {
                return;
            }
            if (mat[i][j] == 1)
            {
                mat[i][j] = 0;

                ClearMatrix(mat, i, j + 1, n, m); // right
                ClearMatrix(mat, i, j - 1, n, m); //left
                ClearMatrix(mat, i - 1, j, n, m); // up
                ClearMatrix(mat, i + 1, j, n, m); // down
                ClearMatrix(mat, i - 1, j - 1, n, m); // diagLU
                ClearMatrix(mat, i + 1, j - 1, n, m); // diagLD
                ClearMatrix(mat, i - 1, j + 1, n, m); // diagRU
                ClearMatrix(mat, i + 1, j - 1, n, m); // diagRD
            }

            return;
        }

    }
}
