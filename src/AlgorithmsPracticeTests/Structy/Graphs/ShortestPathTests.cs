using AlgorithmsPractice.Structy.Graphs;
using Xunit;

namespace AlgorithmsPracticeTests.Structy.Graphs
{
    public class ShortestPathTests
    {
        [Fact]
        public void ShortestPathShouldWork()
        {
            var input = new char[][]
            {
                new char[] {'w', 'x'},
                new char[] {'x', 'y'},
                new char[] {'z', 'y'},
                new char[] {'z', 'v'},
                new char[] {'w', 'v'},
            };

            var result = ShortestPath.GetShortestPath(input, 'w', 'z');
            Assert.Equal(2, result);
        }

        [Fact]
        public void ShortestPathShouldWork2()
        {
            var input = new char[][]
            {
                new char[] {'w', 'x'},
                new char[] {'x', 'y'},
                new char[] {'z', 'y'},
                new char[] {'z', 'v'},
                new char[] {'w', 'v'},
            };

            var result = ShortestPath.GetShortestPath(input, 'y', 'x');
            Assert.Equal(1, result);
        }

        [Fact]
        public void ShortestPathShouldWork4()
        {
            var input = new char[][]
            {
                new char[] { 'a', 'c' },
                new char[] { 'a', 'b' },
                new char[] { 'c', 'b' },
                new char[] { 'c', 'd' },
                new char[] { 'b', 'd' },
                new char[] { 'e', 'd' },
                new char[] { 'g', 'f' }
            };

            var result = ShortestPath.GetShortestPath(input, 'b', 'g');
            Assert.Equal(-1, result);
        }
    }
}
