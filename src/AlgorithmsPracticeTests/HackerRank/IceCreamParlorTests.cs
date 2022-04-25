using AlgorithmsPractice.HackerRank;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlgorithmsPracticeTests.HackerRank
{
    public class IceCreamParlorTests
    {
        [Fact]
        public void ShouldFindIceCreams()
        {
            var iceCreams = new int[] { 6, 7, 1, 8, 3, 5,  11 };

            var result = IceCreamParlor.FindChoices(iceCreams, 10);

            Assert.Equal(result, new int[] { 4, 1 });
        }
    }
}
