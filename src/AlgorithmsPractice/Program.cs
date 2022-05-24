using System;
using AlgorithmsPractice.Codility;
using AlgorithmsPractice.Codility.Arrays;
using AlgorithmsPractice.Codility.CountingElements;
using AlgorithmsPractice.Codility.Iterations;
using AlgorithmsPractice.Codility.Lesson6_Sorting;
using AlgorithmsPractice.Codility.PrefixSums;
using AlgorithmsPractice.Codility.TimeComplexity;
using FrogJumps = AlgorithmsPractice.Codility.CountingElements.FrogJumps;

namespace AlgorithmsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Codility();
        }

        static void Codility()
        {
            //            // Counting Elements
            //            var frogJumps = new FrogJumps();
            //            frogJumps.Solution();
            //            
            //            var countingOperations = new CountingOperations();
            //            countingOperations.Solution();

            //            var missingInteger = new MissingInteger();
            //            missingInteger.Solution();

            //            var countDiv = new CountDiv();
            //            countDiv.Solution();

            //            var genomicRangeQuery = new GenomicRangeQuery();
            //            genomicRangeQuery.Solution();

            //var passingCars = new PassingCars();
            //passingCars.Solution();

            //var sorting = new MaxProductOfThree();
            //sorting.Solution();

            var numberOfDiscIntersections = new NumberOfDiscIntersections();
            numberOfDiscIntersections.Solution(new[] { 1, 5, 2, 1, 4, 0 });

        }
    }
}