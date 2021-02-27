using System;
using System.Collections.Generic;
using System.Text;

namespace MergeSortAlgorithm
{
    public static class Algorithm
    {
        public static void DoMergeSort(this int[] numbers)
        {
            var sortedNumbers = MergeSort(numbers);
            for (int i = 0; i < sortedNumbers.Lenght; i++)
            {
                numbers[i] = sortedNumbers[i];
            }
        }
    }
}
