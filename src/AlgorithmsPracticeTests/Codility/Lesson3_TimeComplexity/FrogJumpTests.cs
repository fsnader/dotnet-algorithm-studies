using AlgorithmsPractice.Codility.TimeComplexity;
using Xunit;

namespace AlgorithmsPracticeTests.Codility.Lesson3_TimeComplexity
{
    public class FrogJumpTests
    {
        [Theory]
        [InlineData(0, 85, 30, 3)]
        public void ShouldWork(int start, int end, int stepSize, int expectedResult)
        {
            var result = FrogJmp.CalculateNumberOfJumps(start, end, stepSize);
            Assert.Equal(expectedResult, result);
        }

    }
}
