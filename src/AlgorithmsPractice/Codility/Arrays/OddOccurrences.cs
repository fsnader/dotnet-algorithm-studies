using System;
using System.Linq;

namespace AlgorithmsPractice.Codility.Arrays
{
    public class OddOccurrences
    {
        public void Solution()
        {
            Console.WriteLine(ReturnUnpaired(new []{9, 3, 9, 3, 9, 7, 9}));
        }

        private int ReturnUnpaired(int[] array)
        {
            var unpaired = array
                .GroupBy(a => a)
                .FirstOrDefault(g => g.Count() % 2 != 0);
            
            return unpaired?.Key ?? 0;
        }
    }
}