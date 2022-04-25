using AlgorithmsPractice.HackerRank;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlgorithmsPracticeTests.HackerRank
{
    public class RecursiveStaircaseTests
    {
        [Theory(Timeout = 10000)]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 4)]
        [InlineData(4, 7)]
        [InlineData(5, 13)]
        [InlineData(30, 53798080)]
        //[InlineData(100, 7367864567128947527)] // Timeout
        public void RecursiveApproach(int steps, int providedResult)
        {
            var result = RecursiveStaircase.CountPath(steps);
            Assert.Equal(result, providedResult);
        }

        [Theory(Timeout = 10000)]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 4)]
        [InlineData(4, 7)]
        [InlineData(5, 13)]
        [InlineData(30, 53798080)]
        [InlineData(100, 7367864567128947527)]
        public void MemorizationApproach(long steps, long providedResult)
        {
            var result = RecursiveStaircase.CountPathWithMemory(steps);
            Assert.Equal(result, providedResult);
        }

        [Theory(Timeout = 10000)]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 4)]
        [InlineData(4, 7)]
        [InlineData(5, 13)]
        [InlineData(30, 53798080)]
        [InlineData(100, 7367864567128947527)]
        public void DynamicProgrammingApproach(long steps, long providedResult)
        {
            var result = RecursiveStaircase.CountPathWithDynamicProgramming(steps);
            Assert.Equal(result, providedResult);
        }
    }
}
