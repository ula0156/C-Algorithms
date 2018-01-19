using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Array;

namespace UnitTests
{
    [TestClass]
    public class GetHeighestRateTests
    {
        [TestMethod]
        public void GetHeighestRate_Test1()
        {
            Tuple<string, int>[] movies = {new Tuple<string, int>("abc", 10), new Tuple<string, int>("abc", 11), new Tuple<string, int>("aac", 3),
            new Tuple<string, int>("acc", 1), new Tuple<string, int>("kkc", 8), new Tuple<string, int>("a", 113), new Tuple<string, int>("agc", 5),
            new Tuple<string, int>("ac", 111), new Tuple<string, int>("qbc", 190), new Tuple<string, int>("asc", 1550)};
            var result = GetHeighestRate.GetTopMovies(movies);

            var x = 0;
        }
    }
}
