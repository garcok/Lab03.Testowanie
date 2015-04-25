﻿namespace Euler18
{
    interface IPermutations
    {
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
        string Run(int numberOfPermutations);
    }
}
