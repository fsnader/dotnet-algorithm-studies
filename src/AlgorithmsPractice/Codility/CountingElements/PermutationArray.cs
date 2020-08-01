using System.Linq;

namespace AlgorithmsPractice.Codility.CountingElements
{
    public class PermutationArray
    {
        public void Solution()
        {
            
        }

        private int IsPermutation(int[] array)
        {
            // Probably O(N * log(N))
            var orderedArray = array
                .OrderBy(a => a) // O(n * log(n))
                .ToList();
            
            // O(n)
            return orderedArray.Where((t, i) => t != i + 1).Any() ?
                0 : 1;
            
//            for (var i = 0; i < orderedArray.Count; i++)
//            {
//                if (orderedArray[i] != i + 1) return 0;
//            }
//
//            return 1;
        }
    }
}