﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler18
{
    public class Permutations : IPermutations
    {
        static int[] permutation = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        /// <summary>
        /// Gets solutions of the problem
        /// </summary>
        /// <param name="numberOfPermutations">number of permutations</param>
        /// <usecase result="2783915460">Run(1000000)</usecase>
        /// <usecase result="0358926471">Run(100000)</usecase>
        /// <usecase result="0123465789">Run(25)</usecase>
        /// <usecase result="0123495786">Run(100)</usecase>
        /// <usecase result="0726348591">Run(250000)</usecase>
        /// <returns>solution</returns>
        public string Run(int numberOfPermutations)
        {
            int counter = 1;

            while (counter < numberOfPermutations)
            {
                int i = permutation.Count() - 1;
                while (permutation[i - 1] > permutation[i])
                {
                    i = i - 1;
                }

                int j = permutation.Count();
                while(permutation[j-1] < permutation[i-1])
                {
                    j = j - 1;
                }

                Swap(i - 1, j - 1, permutation);

                i++;
                j = permutation.Count();

                while(i < j)
                {
                    Swap(i - 1, j - 1, permutation);
                    i++;
                    j--;
                }
                    counter++;
            }

            string solution = GetTable(permutation);

            return solution;
        }

        /// <summary>
        /// Gets elements of the table.
        /// </summary>
        /// <usecase result="123">GetTable(new int[] {1,2,4})</usecase>
        /// <usecase result="45616">GetTable(new int[] {4,5,6,1,6})</usecase>
        /// <usecase result="14567261">GetTable(new int[] {1,4,5,6,7,2,6,1})</usecase>
        /// <returns>Elements of the table</returns>
        private string GetTable(int[] permutation)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Swap two elements in table.
        /// </summary>
        /// <param name="i">index of first element</param>
        /// <param name="j">index of second element</param>
        /// <usecase table="{4,2,1}">0, 2, Swap(new int[] {1,2,4})</usecase>
        /// <usecase table="{5,4,6,1,6}">Swap(0, 1, new int[] {4,5,6,1,6})</usecase>
        /// <usecase table="{1,4,6,5,7,2,6,1}">Swap(2, 3, new int[] {1,4,5,6,7,2,6,1})</usecase>
        /// <param name="table">table</param>
        private void Swap(int p1, int p2, int[] table)
        {
            throw new NotImplementedException();
        }
    }
}
