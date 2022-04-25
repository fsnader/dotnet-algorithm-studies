using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPractice.HackerRank
{
    public static class MakeChange
    {
        public static long FindChanges(int[] coins, int money)
        {
            return FindChanges(coins, money, 0, new Dictionary<string, long>());
        }

        private static long FindChanges(int[] coins, int money, int index, Dictionary<string, long> memo)
        {
            if (money == 0) return 1;
            if (index >= coins.Length) return 0;

            var  key = $"{money}:{index}";

            if (memo.ContainsKey(key)) return memo[key];

            int amountWithCoins = 0;
            long ways = 0;
            while (amountWithCoins <= money)
            {
                int remaining = money - amountWithCoins;
                ways += FindChanges(coins, remaining, index + 1, memo);
                amountWithCoins += coins[index];
            }

            memo[key] = ways;
            return ways;
        }
    }
}
