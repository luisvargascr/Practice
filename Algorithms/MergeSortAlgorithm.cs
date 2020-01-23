namespace Algorithms
{
    public static class MergeSortAlgorithm
    {
        // Time  = O(n lg n)
        // Space = O(n)

        private static void Merge(int[] arr, int left, int middle, int right)
        {
            int[] tmp = new int[arr.Length];

            // Copy both parts into the helper array
            for (int i = left; i <= right; i++)
                tmp[i] = arr[i];

            int left_org_arr = left;
            int left_tmp_arr = left;
            int pivot = middle + 1;

            // Copy the smallest values from either the left or the right side back
            // to the original array
            while (left_tmp_arr <= middle && pivot <= right)
            {
                if (tmp[left_tmp_arr] <= tmp[pivot])
                {
                    arr[left_org_arr] = tmp[left_tmp_arr];
                    left_tmp_arr++;
                }
                else
                {
                    arr[left_org_arr] = tmp[pivot];
                    pivot++;
                }
                left_org_arr++;
            }
            // Copy the rest of the left side of the array into the target array
            while (left_tmp_arr <= middle)
            {
                arr[left_org_arr] = tmp[left_tmp_arr];
                left_org_arr++;
                left_tmp_arr++;
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
