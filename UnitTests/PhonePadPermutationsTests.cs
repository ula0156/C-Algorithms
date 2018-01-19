using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Recusion;

namespace UnitTests
{
    [TestClass]
    public class PhonePadTests
    {
        [TestMethod]
        public void ListOfPermutations()
        {
            var result = PhonePad.AllPossiblePermutations();
        }
    }
}
