namespace Algorithms
{
    public static class HeapSortAlgorithm
    {
        // Time  = O(n log n)
        // Space = O(n)
        public static void HeapSort(int[] arr)
        {
            int arr_length = arr.Length;

            for (int i = arr_length / 2 - 1; i >= 0; i--)
                Heapify(arr, arr_length, i);

            for (int i = arr_length - 1; i >= 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                Heapify(arr, i, 0);
            }
        }
        public static void Heapify(int[] arr, int arr_length, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < arr_length && arr[left] > arr[largest])
                largest = left;

            if (right < arr_length && arr[right] > arr[largest])
                largest = right;

            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                Heapify(arr, arr_length, largest);
            }
        }
    }
}
