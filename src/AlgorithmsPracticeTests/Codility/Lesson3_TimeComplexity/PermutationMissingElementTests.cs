using AlgorithmsPractice.Codility.TimeComplexity;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlgorithmsPracticeTests.Codility.Lesson3_TimeComplexity
{
    public class PermutationMissingElementTests
    {
        [Theory]
        [InlineData(new [] { 2, 3, 1, 5 }, 4)]
        public void ShouldWork(int[] input, int expectedResult)
        {
            var result = PermutationMissingElement.GetMissingNumber(input);
            Assert.Equal(result, expectedResult);
        }
    }
}
