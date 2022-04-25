using AlgorithmsPractice.HackerRank;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlgorithmsPracticeTests.HackerRank
{
    public class CoinChange
    {
        [Fact]
        public void CoinChangeShouldWork()
        {
            var coins = new int[] { 1, 2, 3 };

            var result = MakeChange.FindChanges(coins, 4);

            Assert.Equal(result, 4);
        }

        [Fact]
        public void CoinChangeShouldWork2()
        {
            var coins = new int[] { 2, 5, 3, 6 };

            var result = MakeChange.FindChanges(coins, 10);

            Assert.Equal(result, 5);
        }

        [Fact]
        public void CoinChangeShouldWork3()
        {
            var coins = new int[] { 1, 5, 10, 25 };

            var result = MakeChange.FindChanges(coins, 15);

            Assert.Equal(result, 6);
        }
    }
}
