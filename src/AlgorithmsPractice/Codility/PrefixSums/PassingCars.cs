using System;
using System.Collections.Generic;

namespace AlgorithmsPractice.Codility.PrefixSums
{
    public class PassingCars
    {
        public void Solution()
        {
            Console.WriteLine(GetPassingCars(new int[] {0, 1, 0, 1, 1}));
        }

        private int GetPassingCars(int[] cars)
        {
            var westCars = 0;
            var carPairs = 0;

            for (var i = cars.Length - 1; i >= 0; i--)
            {
                var car = cars[i];
                switch (car)
                {
                    case 0:
                        carPairs += westCars;
                        break;
                    case 1:
                        westCars++;
                        break;
                }

                if (carPairs > 1000000000)
                    return -1;
            }

            return carPairs;
        }
    }

    public class Counters
    {
        public int East { get; set; }
        public int West { get; set; }
    }
}