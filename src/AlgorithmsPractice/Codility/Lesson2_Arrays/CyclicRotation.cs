using System;

namespace AlgorithmsPractice.Codility.Arrays
{
    public class CyclicRotation
    {
        public void Solution()
        {
            // Happy path
            Console.WriteLine(ShiftArray(new[] {3, 8, 9, 7, 6}, 3));
            
            // Empty array
            Console.WriteLine(ShiftArray(Array.Empty<int>(), 3));
            
            // Shift equals to array length
            Console.WriteLine(ShiftArray(new[] {3, 8, 9, 7, 6}, 5));
            
            // Shift greater than array length
            Console.WriteLine(ShiftArray(new[] {3, 8, 9, 7, 6}, 7));
        }

        private int[] ShiftArray(int[] source, int shift)
        {
            if (source.Length == 0) return source;

            if (source.Length < shift) shift %= source.Length;

            var destination = new int[source.Length];
            
            Array.Copy(
                source,
                0,
                destination,
                shift, 
                source.Length - shift);
            
            Array.Copy(
                source, 
                source.Length - shift, 
                destination, 
                0, shift);

            return destination;
        }
    }
}