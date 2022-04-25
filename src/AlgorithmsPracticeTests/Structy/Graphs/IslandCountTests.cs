using AlgorithmsPractice.Structy.Graphs;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlgorithmsPracticeTests.Structy.Graphs
{
    public class IslandCountTests
    {
        [Fact]
        public void IslandCountShouldWork0()
        {
            var input = new char[][]
            {
              new char[] {'W', 'L', 'W', 'W', 'W'},
              new char[] {'W', 'L', 'W', 'W', 'W'},
              new char[] {'W', 'W', 'W', 'L', 'W'},
              new char[] {'W', 'W', 'L', 'L', 'W'},
              new char[] {'L', 'W', 'W', 'L', 'L'},
              new char[] {'L', 'L', 'W', 'W', 'W'},
            };

            var result = IslandCount.GetCount(input);
            Assert.Equal(3, result);
        }

        [Fact]
        public void IslandCountShouldWork1()
        {
            var input = new char[][]
            {
              new char[] {'L', 'W', 'W', 'L', 'W'},
              new char[] {'L', 'W', 'W', 'L', 'L'},
              new char[] {'W', 'L', 'W', 'L', 'W'},
              new char[] {'W', 'W', 'W', 'W', 'W'},
              new char[] {'W', 'W', 'L', 'L', 'L'},
            };

            var result = IslandCount.GetCount(input);
            Assert.Equal(4, result);
        }

        [Fact]
        public void IslandCountShouldWork2()
        {
            var input = new char[][]
            {
              new char[] {'L', 'L', 'L'},
              new char[] {'L', 'L', 'L'},
              new char[] {'L', 'L', 'L'},
            };

            var result = IslandCount.GetCount(input);
            Assert.Equal(1, result);
        }

        [Fact]
        public void IslandCountShouldWork3()
        {
            var input = new char[][]
            {
              new char[] {'W', 'W'},
              new char[] {'W', 'W'},
            };

            var result = IslandCount.GetCount(input);
            Assert.Equal(0, result);
        }

        [Fact]
        public void SmallerIslandShouldWork1()
        {
            var input = new char[][]
{
              new char[] {'W', 'L', 'W', 'W', 'W'},
              new char[] {'W', 'L', 'W', 'W', 'W'},
              new char[] {'W', 'W', 'W', 'L', 'W'},
              new char[] {'W', 'W', 'L', 'L', 'W'},
              new char[] {'L', 'W', 'W', 'L', 'L'},
              new char[] {'L', 'L', 'W', 'W', 'W'},
};

            var result = IslandCount.GetSmallestIsland(input);
            Assert.Equal(2, result);
        }

        [Fact]
        public void SmallerIslandShouldWork2()
        {
            var input = new char[][]
            {
              new char[] {'L', 'W', 'W', 'L', 'W'},
              new char[] {'L', 'W', 'W', 'L', 'L'},
              new char[] {'W', 'L', 'W', 'L', 'W'},
              new char[] {'W', 'W', 'W', 'W', 'W'},
              new char[] {'W', 'W', 'L', 'L', 'L'},
            };

            var result = IslandCount.GetSmallestIsland(input);
            Assert.Equal(1, result);
        }


        [Fact]
        public void SmallerIslandShouldWork3()
        {
            var input = new char[][]
            {
              new char[] {'L', 'L', 'L'},
              new char[] {'L', 'L', 'L'},
              new char[] {'L', 'L', 'L'},
            };

            var result = IslandCount.GetSmallestIsland(input);
            Assert.Equal(9, result);
        }

        [Fact]
        public void SmallerIslandShouldWork4()
        {
            var input = new char[][]
            {
              new char[] {'W', 'W'},
              new char[] {'W', 'W'},
            };

            var result = IslandCount.GetSmallestIsland(input);
            Assert.Equal(0, result);
        }

        [Fact]
        public void SmallerIslandShouldWork5()
        {
            var input = new char[][]
            {
              new char[] {'W', 'W'},
              new char[] {'L', 'L'},
              new char[] {'W', 'W'},
              new char[] {'W', 'L'},
            };

            var result = IslandCount.GetSmallestIsland(input);
            Assert.Equal(1, result);
        }
    }
}
