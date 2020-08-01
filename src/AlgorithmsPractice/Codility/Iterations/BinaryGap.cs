using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsPractice.Codility.Iterations
{
    public class BinaryGap
    {

        public void Solution()
        {
            Console.WriteLine(CalculateBinaryGap(1041));
        }

        private int CalculateBinaryGap(int number)
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

        public string ConvertToBinary(int decimalNumber)
        {
            return Convert.ToString(decimalNumber, 2);;
        }
    }
}