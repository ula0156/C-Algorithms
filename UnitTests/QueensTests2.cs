using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights;

namespace UnitTests
{
    [TestClass]
    public class QueensTests2
    {

        [TestMethod]
        public void RowAttackTest()
        {
            int n = 8;
            int[][] queens = new int[][] { new int[2] { 2, 3 } };
            int[][] queries = new int[][] { new int[2] { 2, 1 } };
            bool[] result = Queens2.SquaresUnderQueenAttack(n, queens, queries);
            CollectionAssert.AreEqual(result, new bool[] { true });
        }

        [TestMethod]
        public void ColumnAttackTest()
        {
            int n = 8;
            int[][] queens = new int[][] { new int[2] { 1, 3 } };
            int[][] queries = new int[][] { new int[2] { 2, 3 } };
            bool[] result = Queens2.SquaresUnderQueenAttack(n, queens, queries);
            CollectionAssert.AreEqual(result, new bool[] { true });
        }

        [TestMethod]
        public void Diagonal1AttackTest()
        {
            int n = 8;
            int[][] queens = new int[][] { new int[2] { 1, 1 } };
            int[][] queries = new int[][] { new int[2] { 3, 3 } };
            bool[] result = Queens2.SquaresUnderQueenAttack(n, queens, queries);
            CollectionAssert.AreEqual(result, new bool[] { true });
        }

        [TestMethod]
        public void Diagonal2AttackTest()
        {
            int n = 8;
            int[][] queens = new int[][] { new int[2] { 1, 3 } };
            int[][] queries = new int[][] { new int[2] { 3, 1 } };
            bool[] result = Queens2.SquaresUnderQueenAttack(n, queens, queries);
            CollectionAssert.AreEqual(result, new bool[] { true });
        }

        [TestMethod]
        public void NoAttackTest()
        {
            int n = 8;
            int[][] queens = new int[][] { new int[2] { 1, 3 } };
            int[][] queries = new int[][] { new int[2] { 2, 1 } };
            bool[] result = Queens2.SquaresUnderQueenAttack(n, queens, queries);
            CollectionAssert.AreEqual(result, new bool[] { false });
        }
    }
}
