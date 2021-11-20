using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsPractice.Codility.Lesson6_Sorting
{
    internal class Distinct
    {
        public int Solution(int[] A)
        {
            return GetNumberOfDistinctValues(A);
            // write your code in C# 6.0 with .NET 4.5 (Mono)
        }

        public int GetNumberOfDistinctValues(int[] elements)
        {
            return elements.GroupBy(x => x).Count();
        }
    }
}
