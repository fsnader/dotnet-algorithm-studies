using System;

namespace AlgorithmsPractice.Codility.PrefixSums
{
    public class CountDiv
    {
        public void Solution()
        {
            Console.WriteLine(CountDivisors_Constant(6, 11, 2)); // Should return 3
        }

        /// <summary>
        /// O(n) solution
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        private int CountDivisors(int a, int b, int k)
        {
            // Must be O(n)
            var edge = 0;
            for (var i = a; i <= b; i++)
            {
                if (i % k == 0) edge++;
            }

            return edge;
        }

        /// <summary>
        /// Constant time solution - O(1)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        private int CountDivisors_Constant(int a, int b, int k)
        {
            var aDividedByK = a % k == 0 ? 1 : 0;
            return (b / k) - (a / k) + aDividedByK;
        }
    }
}