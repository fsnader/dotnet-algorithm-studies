using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsPractice.Codility.Lesson6_Sorting
{
    internal class MaxProductOfThree
    {
        public int Solution()
        {
            var elements = new int[] { - 6, -5, -3, 1, 2, -2, 5, 6 };

            return GetMaxProductOfThree(elements);
        }

        private static int GetMaxProductOfThree(int[] elements)
        {
            var lenght = elements.Length;

            var sortedNumbers = elements
                .OrderBy(e => e)
                .ToArray();

            var smallestTwo = 
                sortedNumbers[0] * 
                sortedNumbers[1] * 
                sortedNumbers[lenght - 1];

            var biggestThree = 
                sortedNumbers[lenght - 1] * 
                sortedNumbers[lenght - 2] *
                sortedNumbers[lenght - 3];

            return smallestTwo > biggestThree ? 
                smallestTwo :
                biggestThree;
        }
    }
}
