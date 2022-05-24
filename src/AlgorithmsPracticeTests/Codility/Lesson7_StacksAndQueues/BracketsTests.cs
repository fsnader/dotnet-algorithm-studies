using AlgorithmsPractice.Codility.Lesson7_StacksAndQueues;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlgorithmsPracticeTests.Codility.Lesson7_StacksAndQueues
{
    public class BracketsTests
    {
        [Theory]
        [InlineData("{[()()]}", 1)]
        [InlineData("([)()]", 0)]
        [InlineData("[[[[[[[[[[[[[[[[[[[[[[[[[", 0)]
        [InlineData("[[[)))", 0)]
        [InlineData("{[()()]}{[()()]}{[()()]}{[()()]}{[()()]}", 1)]
        [InlineData("]]]]]", 0)]
        public void ShouldWork(string input, int expectedResult)
        {
            var result = Brackets.IsNested(input);
            Assert.Equal(expectedResult, result);
        }
    }
}
