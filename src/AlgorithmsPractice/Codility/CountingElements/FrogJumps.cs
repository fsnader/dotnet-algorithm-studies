using System;
using System.Collections.Generic;

namespace AlgorithmsPractice.Codility.CountingElements
{
    public class FrogJumps
    {
        public void Solution()
        {
            // Using HashList
            Console.WriteLine(CalculateMinimumTime(5, new [] { 1, 3, 1, 4, 2, 3, 5, 4}));
            // Using bool array
            Console.WriteLine(CalculateMinimumTimeUsingBools(5, new [] { 1, 3, 1, 4, 2, 3, 5, 4}));
        }

        /// <summary>
        /// Using HashList - O(n)
        /// </summary>
        /// <param name="riverLength"></param>
        /// <param name="timeSeries"></param>
        /// <returns></returns>
        private int CalculateMinimumTime(int riverLength, int[] timeSeries)
        {
            var leftLeafs = new HashSet<int>();
            for (var i = 1; i <= riverLength; i++)
            {
                leftLeafs.Add(i);
            }

            for (var t = 0; t < timeSeries.Length; t++)
            {
                var leaf = timeSeries[t];
                if (leaf - 1 <= riverLength)
                {
                    leftLeafs.Remove(leaf);
                }

                if (leftLeafs.Count == 0)
                {
                    return t;
                }
            }

            return -1;
        }
        
        /// <summary>
        /// Using bool arrays - O(n)
        /// </summary>
        /// <param name="riverLength"></param>
        /// <param name="timeSeries"></param>
        /// <returns></returns>
        private int CalculateMinimumTimeUsingBools(int riverLength, int[] timeSeries)
        {
            var occupiedLeafs = new bool[riverLength];
            var occupiedPositions = 0;

            for (var t = 0; t < timeSeries.Length; t++)
            {
                var leaf = timeSeries[t];
                if (leaf <= riverLength && !occupiedLeafs[leaf - 1])
                {
                    occupiedLeafs[leaf - 1] = true;
                    occupiedPositions++;
                }

                if (occupiedPositions == riverLength)
                {
                    return t;
                }
            }

            return -1;
        }
    }
}