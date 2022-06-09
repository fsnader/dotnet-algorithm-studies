using AlgorithmsPractice.Codility.Lesson8_Leader;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlgorithmsPracticeTests.Codility.Lesson8_Leader
{
    public class LeaderTests
    {
        [Theory]
        [InlineData(new[] { 6, 8, 4, 6, 8, 6, 6 }, 6)]
        [InlineData(new[] { 3, 4, 3, 3, 2, 3, -1, 3, 3}, 3)]
        public void SlowShouldWork(int[] array, int expectedResult)
        {
            var result = Leader.SlowLeader(array);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(new[] { 6, 8, 4, 6, 8, 6, 6 }, 6)]
        [InlineData(new[] { 3, 4, 3, 3, 2, 3, -1, 3, 3 }, 3)]
        public void FastShouldWork(int[] array, int expectedResult)
        {
            var result = Leader.FastLeader(array);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(new[] { 6, 8, 4, 6, 8, 6, 6 }, 6)]
        [InlineData(new[] { 3, 4, 3, 3, 2, 3, -1, 3, 3 }, 3)]
        public void GoldenShouldWork(int[] array, int expectedResult)
        {
            var result = Leader.GoldenLeader(array);
            Assert.Equal(expectedResult, result);
        }
    }
}
