using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test;
using Test.Recusion;

namespace UnitTests
{
    [TestClass]
    public class MatrixTests
    {
        [TestMethod]
        public void CreateMatrix()
        {
            int n = 4;
            int m = 5;
            var mat = MatrixUtils.Matrix(n, m);
            MatrixUtils.FillMatrix(mat, n, m);
            MatrixUtils.PrintMatrix(mat);
            var result = NumberOfObjects._NumberOfObjects(mat, n, m);
            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void MinDistanceRobot_oneWay()
        {
            int[][] mat = new int[4][] { new int[] {0, 0, 5, 0}, new int[] {0, 5, 5, 5 }, new int[] {0, 5, 0, 5 }, new int[] {0, 0, 0, 10}, };
            var result = RobotMinDistance.FindRobotMinDistance(mat, 0, 0);
            Assert.AreEqual(result, 6);
        }
    }
}
