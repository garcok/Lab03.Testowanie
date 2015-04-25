using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Euler18.Tests
{
    [TestClass]
    public class PermutationsTests
    {
        Permutations permutations = new Permutations();

        [TestMethod]
        public void Run()
        {
            // Expected values
            string expected1000000 = "2783915460";
            string expected100000 = "2783915460";
            string expected25 = "2783915460";
            string expected100 = "2783915460";
            string expected250000 = "2783915460";

            // Results
            string result1000000 = permutations.Run(1000000);
            string result100000 = permutations.Run(100000);
            string result25 = permutations.Run(25);
            string result100 = permutations.Run(100);
            string result250000 = permutations.Run(250000);

            // Asserts
            Assert.AreEqual(expected1000000, result1000000, "Error with argument 1000000");
            Assert.AreEqual(expected100000, result100000, "Error with argument 100000");
            Assert.AreEqual(expected25, result25, "Error with argument 25");
            Assert.AreEqual(expected100, result100, "Error with argument 100");
            Assert.AreEqual(expected250000, result250000, "Error with argument 250000");

        }
    }
}
