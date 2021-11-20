using System;

namespace AlgorithmsPractice.Codility.TimeComplexity
{
    public class FrogJmp
    {
        public void Solution()
        {
            Console.WriteLine(CalculateNumberOfJumps(0, 85, 30));
        }

        private int CalculateNumberOfJumps(int start, int end, int stepSize)
        {
            if (end <= start) return 0;
            if (stepSize <= 0) return 0;

            var distance = end - start;
            var steps = distance / stepSize;
            var remaining = distance % stepSize;

            return remaining == 0 ? steps : steps + 1;
        }
    }
}