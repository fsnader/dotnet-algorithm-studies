using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsPractice.Codility.Lesson6_Sorting
{
    internal class NumberOfDiscIntersections
    {
        // O(n**2)
        public int Solution_On2(int[] array)
        {
            var length = array.Length;

            int intersections = 0;
            for(int i = 0;i < length; i++)
            {
                var currentCircle = new Circle()
                {
                    Position = i,
                    Size = array[i]
                };

                for (int j = i+1; j < length; j++)
                {
                    var verifiedCircle = new Circle()
                    {
                        Position = j,
                        Size = array[j]
                    };

                    if (currentCircle.AreIntersecteds(verifiedCircle))
                    {                            
                        intersections++;
                    }
                }

                if (intersections >= 10000000)
                {
                    return -1;
                }
            }

            return intersections;
        }

        /// <summary>
        /// https://stackoverflow.com/questions/4801242/algorithm-to-calculate-number-of-intersecting-discs/4804624
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int Solution(int[] array)
        {
            var lenght = array.Length;
            int result = 0;
            int[] diskStartPoints = new int[lenght];
            int[] distEndPoints = new int[lenght];

            var t = lenght - 1;
            for (int i = 0; i < lenght; i++)
            {
                int start = i > array[i] ? i - array[i] : 0;
                int end = t - i > array[i] ? i + array[i] : t;
                diskStartPoints[start]++;
                distEndPoints[end]++;
            }

            t = 0;
            for (int i = 0; i < lenght; i++)
            {
                if (diskStartPoints[i] > 0)
                {
                    result += t * diskStartPoints[i];
                    result += diskStartPoints[i] * (diskStartPoints[i] - 1) / 2;
                    if (10000000 < result) return -1;
                    t += diskStartPoints[i];
                }
                t -= distEndPoints[i];
            }

            return result;
        }
    }

    public class Circle
    {
        public int Position { get; set; }
        public long Size { get; set; }
        public long FirstPoint => Position - Size;
        public long LastPoint => Position + Size;

        public bool IsPointInside(long point)
        {
            return point >= FirstPoint && point <= LastPoint;
        }

        public bool AreIntersecteds(Circle circle)
        {
            return 
                IsPointInside(circle.FirstPoint) ||
                IsPointInside(circle.LastPoint) ||
                circle.IsPointInside(FirstPoint) || 
                circle.IsPointInside(LastPoint);
        }
    }
}
