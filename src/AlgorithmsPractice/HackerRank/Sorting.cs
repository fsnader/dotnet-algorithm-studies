using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsPractice.HackerRank
{
    public static class Sorting
    {
        public static int[] BubbleSort(this int[] array)
        {
            var isSorted = false;
            var lastUnsorted = array.Length - 1;

            while (!isSorted)
            {
                isSorted = true;
                for (int i = 0; i < lastUnsorted; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                        isSorted = false;
                    }
                }
                lastUnsorted--;
            }

            return array;
        }

        private static void Swap(int[] array, int left, int right)
        {
            var temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }

        public static int[] QuickSort(this int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
            return array;
        }

        private static void QuickSort(int[] array, int left, int right)
        {
            if (left >= right) return;

            int pivot = array[(left + right) / 2];
            int index = Partition(array, left, right, pivot);

            QuickSort(array, left, index - 1);
            QuickSort(array, index, right);
        }

        private static int Partition(int[] array, int left, int right, int pivot)
        {
            while (left <= right)
            {
                while (array[left] < pivot) left++;
                while (array[right] > pivot) right--;

                if (left <= right)
                {
                    Swap(array, left, right);
                    left++;
                    right--;
                }
            }

            return left;
        }

        // O(n^2)


        public static int[] MergeSort(this int[] array)
        {
            MergeSort(array, 0, array.Length - 1, new int[array.Length]);
            return array;
        }

        private static void MergeSort(int[] array, int leftStart, int rightEnd, int[] temp)
        {
            if (leftStart >= rightEnd)
            {
                return;
            }

            var middle = (leftStart + rightEnd) / 2;

            MergeSort(array, leftStart, middle, temp);
            MergeSort(array, middle + 1, rightEnd, temp);
            MergeHalves(array, leftStart, rightEnd, temp);
        }

        private static void MergeHalves(int[] array, int leftStart, int rightEnd, int[] temp)
        {
            var leftEnd = (rightEnd + leftStart) / 2;
            var rightStart = leftEnd + 1;
            var size = rightEnd - leftStart + 1;

            var leftIndex = leftStart;
            var rightIndex = rightStart;
            var index = leftStart;

            while(leftIndex <= leftEnd && rightIndex <= rightEnd)
            {
                if (array[leftIndex] <= array[rightIndex])
                {
                    temp[index] = array[leftIndex];
                    leftIndex++;
                }
                else
                {
                    temp[index] = array[rightIndex];
                    rightIndex++;
                }
                index++;
            }

            Array.Copy(array, leftIndex, temp, index, leftEnd - leftIndex + 1);
            Array.Copy(array, rightIndex, temp, index, rightEnd - rightIndex + 1);
            Array.Copy(temp, leftStart, array, leftStart, size);
        }
    }
}
