using System;
using System.Linq;

namespace AlgorithmsPractice.Codility.TimeComplexity
{
    public class PermutationMissingElement
    {
        public void Solution()
        {
            Console.WriteLine(GetMissingNumber(new []{2, 3, 1, 5}));
        }

        private int GetMissingNumber(int[] array)
        {
            if (array.Length == 0) return 1;
            
            var orderedArray = array
                .OrderBy(n => n)
                .ToList();

            for (var i = 0; i < orderedArray.Count; i++)
            {
                if (orderedArray[i] != i + 1) return i + 1;
            }

            return orderedArray.Count + 1;
        }
    }
}