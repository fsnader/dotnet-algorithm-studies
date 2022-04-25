using AlgorithmsPractice.HackerRank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace AlgorithmsPracticeTests.HackerRank
{
    public class Sorting
    {
        [Fact]
        public void QuickSortShouldWork()
        {
            var array = new[] { 6, 7, 3, 2, 1, 4, 9, 5, 8 };
            var result = array.QuickSort();

            Assert.Equal(result, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, });
        }

        // O(n^2)
        [Fact]
        public void BubbleSortShouldWork()
        {
            var array = new[] { 6, 7, 3, 2, 1, 4, 9, 5, 8};
            var result = array.BubbleSort();

            Assert.Equal(result, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, });
        }

        [Fact]
        public void MergeSortShouldWork()
        {
            var array = new[] { 6, 7, 3, 2, 1, 4, 9, 5, 8 };
            var result = array.MergeSort();

            Assert.Equal(result, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, });
        }
    }
}
