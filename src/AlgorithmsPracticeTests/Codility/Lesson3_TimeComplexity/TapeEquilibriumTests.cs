using AlgorithmsPractice.Codility.TimeComplexity;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlgorithmsPracticeTests.Codility.Lesson3_TimeComplexity
{
    public class TapeEquilibriumTests
    {
        [Theory]
        [InlineData(new[] { 3, 1, 2, 4, 3 }, 1)]
        public void On_square_shouldWork(int[] input, int expectedOutput)
        {
            var result = TapeEquilibrium.GetMinimalDifference(input);
            Assert.Equal(expectedOutput, result);
        }

        [Theory]
        [InlineData(new[] { 3, 1, 2, 4, 3 }, 1)]
        public void On_shouldWork(int[] input, int expectedOutput)
        {
            var result = TapeEquilibrium.GetMinimalDifference2(input);
            Assert.Equal(expectedOutput, result);
        }
    }
}
