using AlgorithmsPractice.Codility.Arrays;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlgorithmsPracticeTests.Codility.Lesson2_Arrays
{
    public class CyclicRotationTests
    {
        [Theory]
        [InlineData(new[] { 3, 8, 9, 7, 6 }, 3, new[] { 9, 7, 6, 3, 8 })]
        [InlineData(new int[0], 3, new int[0])]
        [InlineData(new[] { 3, 8, 9, 7, 6 }, 5, new[] { 3, 8, 9, 7, 6 })]
        [InlineData(new[] { 3, 8, 9, 7, 6 }, 7, new[] { 8, 9, 7, 6, 3 })]
        public void ShouldWork(int[] array, int shift, int[] expectedArray)
        {
            var result = CyclicRotation.ShiftArray(array, shift);
            Assert.Equal(expectedArray, result);
        }
    }
}
