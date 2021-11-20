using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsPractice.Codility.Lesson6_Sorting
{
    internal class Triangle
    {
        public int Solution(int[] elements)
        {
            var lenght = elements.Length;

            if (lenght < 3) return 0;

            var orderedArray = elements
                .OrderBy(e => e)
                .ToArray();

            for (int i = 0; i < lenght - 2; i++)
            {
                // É preciso inverter a conta para evitar um overflow do int
                if (orderedArray[i] > (orderedArray[i + 2] - orderedArray[i + 1]))
                {
                    return 1;
                }

            }

            return 0;
        }
    }
}
