using System;
using System.Linq;

namespace AlgorithmsPractice.Codility.CountingElements
{
    public class MissingInteger
    {
        public void Solution()
        {
            // Must be O(N) or O(N * log(N))
            Console.WriteLine(ReturnSmallestPositive(new[] {1, 3, 6, 4, 1, 2})); // Must return 5
            Console.WriteLine(ReturnSmallestPositive(new[] {1, 2, 3})); // Must return 4
            Console.WriteLine(ReturnSmallestPositive(new[] {-1, -3})); // Must return 1
        }

        private int ReturnSmallestPositive(int[] array)
        {
            // Probably O(N * log(N))
            var orderedArray = array
                .Where(a => a > 0) // O(n)
                .Distinct() // O(n)
                .OrderBy(a => a) // O(n * log(n))
                .ToList();

            if (orderedArray.Count == 0) return 1;

            // O(N)
            for (var i = 0; i < orderedArray.Count; i++)
            {
                if (orderedArray[i] != i + 1)
                    return i + 1;
            }

            return orderedArray.Count + 1;
        }
    }
}