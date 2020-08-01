using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsPractice.Codility.PrefixSums
{
    public class GenomicRangeQuery
    {
        public void Solution()
        {
//            var P = new int[] {2, 5, 0};
//            var Q = new int[] {4, 5, 6};
//
//            Console.WriteLine(GetMinimalNucleotide_2("CAGCCTA", P, Q));

            var P = new int[] {2, 5, 0};
            var Q = new int[] {4, 5, 6};

            Console.WriteLine(GetMinimalNucleotide_PrefixSums("AAGCCTA", P, Q));
        }

        private int[] GetMinimalNucleotide_Linq(string dna, int[] p, int[] q)
        {
            var impactFactors = dna
                .Select(GetImpactFactor)
                .ToArray();


            var results = new int[p.Length];
            for (var i = 0; i < p.Length; i++)
            {
                results[i] = GetMinimalNucleotide(impactFactors, p[i], q[i]);
            }


            return results;
        }

        private int GetMinimalNucleotide(IEnumerable<int> dna, int p, int q)
        {
            return dna
                .Skip(p)
                .Take(q - p + 1)
                .Min();
        }

        private int GetImpactFactor(char nucleotide)
        {
            switch (nucleotide)
            {
                case 'A':
                    return 1;
                case 'C':
                    return 2;
                case 'G':
                    return 3;
                case 'T':
                    return 4;
                default:
                    return 1;
            }
        }

        private int[] GetMinimalNucleotide_PrefixSums(string dna, int[] p, int[] q)
        {
            var counters = new List<PrefixCounters> {new PrefixCounters()};

            var totalCounters = new PrefixCounters();

            foreach (var nucleotide in dna)
            {
                switch (nucleotide)
                {
                    case 'A':
                        totalCounters.A++;
                        break;
                    case 'C':
                        totalCounters.C++;
                        break;
                    case 'G':
                        totalCounters.G++;
                        break;
                    case 'T':
                        totalCounters.T++;
                        break;
                }

                counters.Add(new PrefixCounters
                {
                    A = totalCounters.A,
                    C = totalCounters.C,
                    G = totalCounters.G,
                    T = totalCounters.T
                });
            }

            var results = new int[p.Length];

            for (var i = 0; i < p.Length; i++)
            {
                var from = counters[q[i]];
                var to = counters[p[i] + 1];

                if (from.A - to.A > 0)
                {
                    results[i] = 1;
                    continue;
                }

                if (from.C - to.C > 0)
                {
                    results[i] = 2;
                    continue;
                }

                if (from.G - to.G > 0)
                {
                    results[i] = 3;
                    continue;
                }

                results[i] = 4;
            }

            return results;
        }
    }

    public class PrefixCounters
    {
        public int A { get; set; }
        public int C { get; set; }
        public int G { get; set; }
        public int T { get; set; }
    }
}