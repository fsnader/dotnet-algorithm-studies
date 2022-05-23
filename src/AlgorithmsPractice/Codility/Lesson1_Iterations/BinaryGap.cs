using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsPractice.Codility.Iterations
{
    public static class BinaryGap
    {
        /*
        A binary gap within a positive integer N is any maximal sequence of consecutive zeros that is surrounded by ones 
        at both ends in the binary representation of N.

        For example, number 9 has binary representation 1001 and contains a binary gap of length 2. The number 529 has binary 
        representation 1000010001 and contains two binary gaps: one of length 4 and one of length 3. The number 20 has binary 
        representation 10100 and contains one binary gap of length 1. The number 15 has binary representation 1111 and has no 
        binary gaps. The number 32 has binary representation 100000 and has no binary gaps.

        Write a function:

        class Solution { public int solution(int N); }

        that, given a positive integer N, returns the length of its longest binary gap. The function should return 0 if N 
        doesn't contain a binary gap.

        For example, given N = 1041 the function should return 5, because N has binary representation 10000010001 and so its longest binary
        gap is of length 5. Given N = 32 the function should return 0, because N has binary representation '100000' and thus no binary gaps.

        Write an efficient algorithm for the following assumptions:

        N is an integer within the range [1..2,147,483,647].
         * */
        public static int Calculate(int number)
        {
            var binaryRepresentation = ConvertToBinary(number);

            var isCurrentlyInGap = false;
            var gapCount = 0;
            var lastBit = '0';
            var gapSizes = new List<int>();
            
            foreach (var actualBit in binaryRepresentation)
            {
                if (isCurrentlyInGap && actualBit == '0')
                {
                    gapCount++;
                }
                
                if (isCurrentlyInGap && lastBit == '0' && actualBit == '1')
                {
                    isCurrentlyInGap = false;
                    gapCount++;
                    gapSizes.Add(gapCount);
                }

                if (!isCurrentlyInGap && lastBit == '1' && actualBit == '0')
                {
                    gapCount = 0;
                    isCurrentlyInGap = true;
                }

                lastBit = actualBit;
            }

            return gapSizes.Any() ? gapSizes.Max() : 0;
        }

        public static string ConvertToBinary(int decimalNumber)
        {
            return Convert.ToString(decimalNumber, 2);;
        }
    }
}