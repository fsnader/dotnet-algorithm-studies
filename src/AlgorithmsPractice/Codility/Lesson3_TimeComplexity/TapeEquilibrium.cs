using System;
using System.Linq;

namespace AlgorithmsPractice.Codility.TimeComplexity
{
    public class TapeEquilibrium
    {
        public void Solution()
        {
            Console.WriteLine(GetMinimalDifference(new[] {3, 1, 2, 4, 3}));
            Console.WriteLine(GetMinimalDifference2(new[] {3, 1, 2, 4, 3}));
        }

        
        /// <summary>
        /// O(N^2) Solution - Wrong
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private int GetMinimalDifference(int[] array)
        {
            if (array.Length == 0) return 0;

            var minimumValue = 0;

            for (var p = 1; p < array.Length; p++)
            {
                var leftSum = array.Take(p).Sum();
                var rightSum = array.Skip(p).Sum();

                var result = Math.Abs(leftSum - rightSum);

                if (p == 1 || result < minimumValue)
                {
                    minimumValue = result;
                }
            }

            return minimumValue;
        }

        /// <summary>
        /// O(N) Solution
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private int GetMinimalDifference2(int[] array)
        {
            var minimumValue = 0;
            var leftSum = 0;
            var rightSum = array.Sum();

            for (var p = 1; p < array.Length; p++)
            {
                leftSum += array[p - 1];
                rightSum -= array[p - 1];
                
                var result = Math.Abs(leftSum - rightSum);
                
                if (p == 1 || result < minimumValue)
                {
                    minimumValue = result;
                }
            }

            return minimumValue;
        }
    }
}