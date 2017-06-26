using System.Collections.Generic;

namespace CodeFights
{
    public class Queens
    {
        public static bool[] SquaresUnderQueenAttack(int n, int[][] queens, int[][] queries)
        {
            HashSet<int> queensRow = new HashSet<int>();
            HashSet<int> queensCol = new HashSet<int>();
            HashSet<int> queensDiagonalUp = new HashSet<int>();
            HashSet<int> queensDiagonalDown = new HashSet<int>();
            bool[] result = new bool[queries.Length];

            foreach (int[] queen in queens)
            {
                int diagonalUp = queen[0] - queen[1];
                int diagonalDown = queen[0] + queen[1];
                queensRow.Add(queen[0]);
                queensCol.Add(queen[1]);
                queensDiagonalUp.Add(diagonalUp);
                queensDiagonalDown.Add(diagonalDown);
            }

            int pos = 0;
            foreach (int[] query in queries)
            {
                int diagonalUp = query[0] - query[1];
                int diagonalDown = query[0] + query[1];
                bool underAttack = queensRow.Contains(query[0]) || queensCol.Contains(query[1]) ||
                    queensRow.Contains(query[0]) || queensDiagonalUp.Contains(diagonalUp) || queensDiagonalDown.Contains(diagonalDown);

                result[pos] = underAttack;
                pos++;
            }

            return result;
        }

    }
}
