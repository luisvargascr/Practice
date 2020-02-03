using System;
namespace Algorithms
{
    public static class QuickSortAlgorithm
    {
        // Time  = O(n log n), worse O(n^2)
        // Space = O(n log n)

        public static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);
                QuickSort(arr, left, pivot);
                QuickSort(arr, pivot + 1, right);
            }
        }
        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];

            while (true)
            {
                while (arr[left] < pivot)
                    left++;

                while (arr[right] > pivot)
                    right--;

                if (left >= right)
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
