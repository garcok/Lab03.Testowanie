using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Euler18.Tests
{
    [TestClass]
    public class PermutationsTests : Permutations
    {
        Permutations permutations = new Permutations();

        [TestMethod]
        public void RunTest()
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

        [TestMethod]
        public void SwapTest()
        {
            // Expected values
            int[] expected1 = new int[] { 4, 2, 1 };
            int[] expected2 = new int[] { 5, 4, 6, 1, 6 };
            int[] expected3 = new int[] { 1, 4, 6, 5, 7, 2, 6, 1 };

            // Tables
            int[] table1 = new int[] { 1, 2, 4 };
            int[] table2 = new int[] { 4, 5, 6, 1, 6 };
            int[] table3 = new int[] { 1, 4, 5, 6, 7, 2, 6, 1 };
           
            // Method run
            base.Swap(0, 2, table1);
            base.Swap(0, 1, table2);
            base.Swap(2, 3, table3);

            // Asserts
            CollectionAssert.AreEqual(expected1, table1, "Error with table1");
            CollectionAssert.AreEqual(expected2, table2, "Error with table2");
            CollectionAssert.AreEqual(expected3, table3, "Error with table3");
        }

        [TestMethod]
        public void GetTableTest()
        {
            // Expected values
            string expected124 = "124";
            string expected45616 = "45616";
            string expected14567261 = "14567261";

            // Tables
            string result124 = base.GetTable(new int[] { 1, 2, 4 });
            string result45616 = base.GetTable(new int[] { 4, 5, 6, 1, 6 });
            string result14567261 = base.GetTable(new int[] { 1, 4, 5, 6, 7, 2, 6, 1 });

            // Asserts
            Assert.AreEqual(expected124, result124, "Error with table {1,2,4}");
            Assert.AreEqual(expected45616, result45616, "Error with table {4,5,6,1,6}");
            Assert.AreEqual(expected14567261, result14567261, "Error with table {1,4,5,6,7,2,6,1}");
        }
    }
}
