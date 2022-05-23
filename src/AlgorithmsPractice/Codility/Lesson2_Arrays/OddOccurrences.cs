using System;
using System.Linq;

namespace AlgorithmsPractice.Codility.Arrays
{
    public static class OddOccurrences
    {
        public static int ReturnUnpaired(int[] array)
        {
            var unpaired = array
                .GroupBy(a => a)
                .FirstOrDefault(g => g.Count() % 2 != 0);
            
            return unpaired?.Key ?? 0;
        }
    }
}