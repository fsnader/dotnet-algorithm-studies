using AlgorithmsPractice.Codility.Iterations;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlgorithmsPracticeTests.Codility.Lesson1_Iterations
{
    public class BinaryGapTests
    {
        [Theory]
        [InlineData(1041, 5)]
        [InlineData(9, 2)]
        [InlineData(529, 4)]
        [InlineData(20, 1)]
        public void BinaryGapShouldWork(int input, int expected)
        {
            var result = BinaryGap.Calculate(input);

            Assert.Equal(expected, result);
        }
    }
}
