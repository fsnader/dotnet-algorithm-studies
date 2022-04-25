using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics.CodeAnalysis;

namespace AlgorithmsPractice.HackerRank
{
    public static class IceCreamParlor
    {
        public static int[] FindChoices(int[] menu, int money)
        {
            var sortedMenu = menu
                .Select((value, index) => new IceCream(index, value))
                .OrderBy(x => x.Value)
                .ToArray();

            for (int i = 0; i < sortedMenu.Length; i++)
            {
                var complement = money - sortedMenu[i].Value;

                var location = Array.BinarySearch(sortedMenu, i + 1, sortedMenu.Length - i - 1, new IceCream(0, complement));

                if (location >= 0)
                {
                    return new int[] { sortedMenu[i].Index, sortedMenu[location].Index };
                }
            }

            return default;
        }
    }

    class IceCream : IComparable<IceCream>
    {
        public int Index { get; set; }
        public int Value { get; set; }

        public IceCream(int index, int value)
        {
            Index = index;
            Value = value;
        }

        public int CompareTo([AllowNull] IceCream other)
        {
            if (Value < other.Value) return -1;
            if (Value > other.Value) return 1;
            return 0;
        }
    }

}
