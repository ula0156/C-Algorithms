using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Array;

namespace UnitTests
{
    [TestClass]
    public class TimeForTasksExecutionTests
    {
        [TestMethod]
        public void TimeForTasksExecutionTests_Test1()
        {
            int[] arr = { 2, 1, 1, 2 };
            var k = 2;
            var result = TimeForTasksExecution.GetTotalTime(arr, k);
            Assert.AreEqual(result, 7);
        }

        [TestMethod]
        public void TimeForTasksExecutionTests_Test2()
        {
            int[] arr = { 1,2,1,3,2,1 };
            var k = 3;
            var result = TimeForTasksExecution.GetTotalTime(arr, k);
            Assert.AreEqual(result, 9);
        }
    }
}
