namespace Algorithms
{
    public static class MergeSortAlgorithm
    {
        // Time  = O(n lg n)
        // Space = O(n)

        private static void Merge(int[] arr, int left, int middle, int right)
        {
            int[] tmp_array = new int[arr.Length];

            // Copy both parts into the helper array
            for (int i = left; i <= right; i++)
            {
                tmp_array[i] = arr[i];
            }
            int left_index   = left;
            int left_pointer = left;
            int pivot = middle + 1;

            // Copy the smallest values from either the left or the right side back
            // to the original array
            while (left_pointer <= middle && pivot <= right)
            {
                if (tmp_array[left_pointer] <= tmp_array[pivot])
                {
                    arr[left_index] = tmp_array[left_pointer];
                    left_pointer++;
                }
                else
                {
                    arr[left_index] = tmp_array[pivot];
                    pivot++;
                }
                left_index++;
            }
            // Copy the rest of the left side of the array into the target array
            while (left_pointer <= middle)
            {
                arr[left_index] = tmp_array[left_pointer];
                left_index++;
                left_pointer++;
            }
            // Since we are sorting in-place any leftover elements from the right side
            // are already at the right position.
        }
        public static void MergeSort(int[] input, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(input, left, middle);
                MergeSort(input, middle + 1, right);
                Merge(input, left, middle, right);
            }
        }
    }
}
