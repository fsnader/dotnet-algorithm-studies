using AlgorithmsPractice.Structy.Graphs;
using System.Collections.Generic;
using Xunit;

namespace AlgorithmsPracticeTests.Structy.Graphs
{
    public class LargestComponentTests
    {
        [Fact]
        public void LargestComponentShouldWork()
        {
            var input = new Dictionary<int, List<int>>
            {
                { 0, new List<int> { 8, 1, 5 } },
                { 1, new List<int> { 0 } },
                { 5, new List<int> { 0, 8 } },
                { 8, new List<int> { 0, 5 } },
                { 2, new List<int> { 3, 4 } },
                { 3, new List<int> { 2, 4 } },
                { 4, new List<int> { 3, 2 } },
            };

            var result = LargestComponent.GetLargest(input);
            Assert.Equal(4, result);
        }

        [Fact]
        public void LargestComponentShouldWork2()
        {
            var input = new Dictionary<int, List<int>>
            {
                { 3, new List<int> { } },
                { 4, new List<int> { 6 } },
                { 6, new List<int> { 4, 5, 7, 8 } },
                { 8, new List<int> { 6 } },
                { 7, new List<int> { 6 } },
                { 5, new List<int> { 6 } },
                { 1, new List<int> { 2 } },
                { 2, new List<int> { 1} }
            };

            var result = LargestComponent.GetLargest(input);
            Assert.Equal(5, result);
        }
    }
}
