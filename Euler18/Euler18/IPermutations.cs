namespace Euler18
{
    interface IPermutations
    {
        /// <summary>
        /// Gets solutions of the problem
        /// </summary>
        /// <param name="numberOfPermutations">number of permutations</param>
        /// <usecase result="2783915460">Run(1000000)</usecase>
        /// <usecase result="3042875169">Run(100000)</usecase>
        /// <usecase result="3042895167">Run(25)</usecase>
        /// <usecase result="3042975681">Run(100)</usecase>
        /// <usecase result="3749102568">Run(250000)</usecase>
        /// <returns>solution</returns>
        string Run(int numberOfPermutations);
    }
}
