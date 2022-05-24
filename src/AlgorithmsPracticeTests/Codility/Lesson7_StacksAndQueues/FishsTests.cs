using AlgorithmsPractice.Codility.Lesson7_StacksAndQueues;
using Xunit;

namespace AlgorithmsPracticeTests.Codility.Lesson7_StacksAndQueues
{
    public class FishsTests
    {
        [Theory]
        [InlineData(new int[] { 4, 3, 2, 1, 5}, new int[] { 0, 1, 0, 0, 0}, 2)]

        // (4, 0) (3, 1) (2, 0) (1, 0) (5, 0)

        public void ShouldWork(int[] sizes, int[] directions, int expectedResult)
        {
            var result = Fishs.GetRemainingFishs(sizes, directions);
            Assert.Equal(expectedResult, result);
        }
    }
}
