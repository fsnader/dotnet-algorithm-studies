using AlgorithmsPractice.Codility.Lesson7_StacksAndQueues;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlgorithmsPracticeTests.Codility.Lesson7_StacksAndQueues
{
    public class StoneWallTests
    {
        [Theory]
        [InlineData(new [] {8, 8, 5, 7, 9, 8, 7, 4, 8}, 7)]
        public void ShouldWork(int[] skyline, int expected)
        {
            var result = StoneWall.GetNumberOfBlocks(skyline);
            Assert.Equal(expected, result);
        }
    }
}
