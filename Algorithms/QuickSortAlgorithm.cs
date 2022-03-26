using System;
namespace Algorithms
{
    public static class QuickSortAlgorithm
    {
        private static int hits = 0;
        // Time  = O(n log (n)), worse O(n^2)
        // Space = O(log (n))
        // Partition-exchange sort
        // In-Place sorting algorithm
        // Divide and Conquer Algorithm
        // Not Stable: relative order of equal sort items is not preserved

        public static void QuickSort(int[] arr, int left, int right)
        {
            Console.WriteLine(string.Format("Hit Count {0}, left {1}, right {2}.", hits++, left, right));
            if (left < right)
            {
                int pivot = Partition(arr, left, right);
                Console.WriteLine(string.Format("Hit Count {0}, left {1}, right {2}, pivot {3}.", hits++, left, right, pivot));
                QuickSort(arr, left, pivot);
                QuickSort(arr, pivot + 1, right);
            }
        }
        private static int Partition(int[] arr, int left, int right)
        {
            // int pivot = Convert.ToInt32(Math.Floor(Convert.ToDecimal((arr[right] + arr[left]) / 2)));
            int pivot = arr[right - 1];

            while (true)
            {
                while (arr[left] < pivot)
                    left++;

                while (arr[right] > pivot)
                    right--;

                //if (left >= right)
                if (right <= left)
                    return right;

                int tmp = arr[left];
                arr[left] = arr[right];
                arr[right] = tmp;

                left++;
                right--;
            }
        }
    }
}
