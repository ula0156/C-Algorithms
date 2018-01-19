using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Stack;

namespace UnitTests
{
    [TestClass]
    public class EvaluateExpressionTests
    {
        [TestMethod]
        public void EvaluateExpression1()
        {
            var s = "5+3*7*2+2*2";
            var result = EvaluateExpression.EvaluateGivenExpression(s);
            Assert.AreEqual(result, 51);
        }

        [TestMethod]
        public void EvaluateExpression2()
        {
            var s = "5*3+7*2+4*2";
            var result = EvaluateExpression.EvaluateGivenExpression(s);
            Assert.AreEqual(result, 37);
        }
    }
}
