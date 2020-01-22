namespace Algorithms
{
    public static class MergeSortAlgorithm
    {
        // Time  = O(n lg n)
        // Space = O(n)

        private static void Merge(int[] numbers, int left, int middle, int right)
        {
            int[] tmp_array = new int[numbers.Length];

            // Copy both parts into the helper array
            for (int cnt = left; cnt <= right; cnt++)
            {
                tmp_array[cnt] = numbers[cnt];
            }
            int left_pointer = left;
            int middle_index = middle + 1;
            int left_index   = left;

            // Copy the smallest values from either the left or the right side back
            // to the original array
            while (left_pointer <= middle && middle_index <= right)
            {
                if (tmp_array[left_pointer] <= tmp_array[middle_index])
                {
                    numbers[left_index] = tmp_array[left_pointer];
                    left_pointer++;
                }
                else
                {
                    numbers[left_index] = tmp_array[middle_index];
                    middle_index++;
                }
                left_index++;
            }
            // Copy the rest of the left side of the array into the target array
            while (left_pointer <= middle)
            {
                numbers[left_index] = tmp_array[left_pointer];
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
