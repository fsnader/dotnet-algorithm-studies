using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsPractice.Codility.Lesson8_Leader
{
    public static class Leader
    {
        public static int SlowLeader(int[] array) // O(N^2)
        {
            var length = array.Length;

            for (var i = 0; i < length; i++) // O(N)
            {
                var candidate = array[i];
                var count = 0;

                for (var j = 0; j < length; j++) // O(N)
                {
                    if (array[j] == candidate)
                    {
                        count++;
                    }
                }

                if (count > length / 2)
                {
                    return candidate;
                }
            }

            return -1;
        }

        public static int FastLeader(int[] array) // N*LOG(N)
        {
            var length = array.Length;
            var count = 0;
            var orderedArray = array.OrderBy(i => i).ToArray(); // LOG (N)
            var candidate = orderedArray[length / 2];


            for (int i = 0; i < length; i++) // O(N)
            {
                if (array[i] == candidate)
                {
                    count++;
                }
            }

            if (count > length / 2)
            {
                return candidate;
            }

            return -1;
        }

        public static int GoldenLeader(int[] array) // O(2*n)
        {
            var length = array.Length;
            var size = 0;

            var value = array[0];

            for (int i = 0; i < length; i++) // O(n)
            {
                if (size == 0)
                {
                    size++;
                    value = array[i];
                }
                else
                {
                    if (value != array[i]) size--;
                    else size++;
                }
            }
            var candidate = -1;

            if (size > 0) candidate = value;

            var count = 0;

            for(int i = 0; i < length; i++) // O(n)
            {
                if (array[i] == candidate)
                {
                    count++;
                }
            }

            if (count > length / 2)
            {
                return candidate;
            }

            return -1;
        }
    }
}
