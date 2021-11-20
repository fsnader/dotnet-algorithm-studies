namespace AlgorithmsPractice.Codility.PrefixSums
{
    public class MinvAvgTwoSlices
    {
        public void Solution()
        {
            
        }

        private int MinimumAverageTwoSlices(int[] source)
        {
            var minimumIndex = 0;
            double minimumValue = 10001;

            for (var i = 0; i < source.Length + 1; i++)
            {
                if (i < source.Length - 1 && (source[i] + source[i + 1]) / 2.0 < minimumValue)
                {
                    minimumIndex = i;
                    minimumValue = (source[i] + source[i + 1]) / 2.0;
                }

                if (i < source.Length - 2 && (source[i] + source[i + 1] + source[i + 2]) / 3.0 < minimumValue)
                {
                    minimumIndex = i;
                    minimumValue = (source[i] + source[i + 1] + source[i + 2]) / 3.0;
                }
            }

            return minimumIndex;
        }

        public int[] GetPrefixSum(int[] source)
        {
            var prefixSum = new int[source.Length + 1];
            prefixSum[0] = 0;

            for (var i = 1; i <= source.Length; ++i)
            {
                prefixSum[i] = prefixSum[i - 1] + source[i];
            }

            return prefixSum;
        }
    }
}