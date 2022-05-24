using AlgorithmsPractice.Codility.Arrays;
using Xunit;

namespace AlgorithmsPracticeTests.Codility.Lesson2_Arrays
{
    public class OddOccurrencesTests
    {
        [Theory]
        [InlineData(new[] { 9, 3, 9, 3, 9, 7, 9 }, 7)]
        public void ShouldWork(int[] array, int expected)
        {
            var result = OddOccurrences.ReturnUnpaired(array);
            Assert.Equal(expected, result);
        }
    }
}
