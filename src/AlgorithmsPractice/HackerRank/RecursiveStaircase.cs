using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPractice.HackerRank
{
    /*
     There are n stairs, a person standing at the bottom wants to reach the top.
     The person can climb either 1, 2 or 3 stairs at a time. We are required to count the number of ways, the person can reach the top.

     We are required to write a function that takes in a number n that denotes the number of stairs. The function should count and return the number of ways in which the stairs can be climbed.
     
     */
    public static class RecursiveStaircase
    {
        public static int CountPath(int steps)
        {
            if (steps < 0) return 0;
            if (steps == 0) return 1;

            return CountPath(steps - 1) + CountPath(steps - 2) + CountPath(steps - 3);
        }

        public static long CountPathWithMemory(long steps) => CountPathWithMemory(steps, new long[steps + 1]);
        public static long CountPathWithMemory(long steps, long[] memory)
        {
            if (steps < 0) return 0;
            if (steps == 0) return 1;

            if (memory[steps] == 0)
            {
                memory[steps] = CountPathWithMemory(steps - 1, memory) 
                    + CountPathWithMemory(steps - 2, memory) 
                    + CountPathWithMemory(steps - 3, memory);
            }

            return memory[steps];
        }

        public static long CountPathWithDynamicProgramming(long steps)
        {
            if (steps < 0) return 0;
            if (steps <= 1) return 1;

            var paths = new long[]
            {
                1, 1, 2
            };

            for (int i = 3; i <= steps; i++)
            {
                long count = paths[2] + paths[1] + paths[0];
                paths[0] = paths[1];
                paths[1] = paths[2];
                paths[2] = count;
            }

            return paths[2];
        }
    }
}
