using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler18
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPermutations = 1000000;
            Permutations permutations = new Permutations();

            string result = permutations.Run(numberOfPermutations);

            Console.WriteLine(string.Format("{0}th {1} {2}", numberOfPermutations, "lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9 is", result));
            Console.ReadLine();
        }
    }
}
