using System;

namespace Algorithms
{
    public static class MergeSortAlgorithm
    {
        // Time  = O(n log n)
        // Space = O(n)
        // Top-down Implementation

        private static void Merge(int[] arr, int left, int middle, int right)
        {
            // Out-of-Place Algorithm - Uses extra memory to accomplish the sorting
            int[] tmp = new int[right + 1];

            // Copy both parts into the helper array
            for (int i = left; i <= right; i++)
                tmp[i] = arr[i];

            // Two pointers begin far left, one is for original array (op = original pointer) and the other for the copy (cp = copy pointer)

            int op = left;
            int cp = left;

            // End sits at middle 
            int end = middle + 1;

            // Copy the smallest values from either the left or the right side back
            // to the original array
            while (cp <= middle && end <= right)
            {
                if (tmp[cp] <= tmp[end])
                {
                    arr[op] = tmp[cp];
                    cp++;
                }
                else
                {
                    arr[op] = tmp[end];
                    end++;
                }
                op++;
            }
            // Copy the rest of the left side of the array into the target array
            while (cp <= middle)
            {
                arr[op] = tmp[cp];
                op++;
                cp++;
            }
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
        public static void MergeSort(int[] original, bool bottomUp = false)
        {
            int size = original.Length;
            int[] copy = new int[size];

            if (bottomUp == true)
            {
                BottomUpSplitMerge(original, copy, size);
            }
            else
            {
                Array.Copy(original, copy, size);
                TopDownSplitMerge(copy, 0, size, original);
                Array.Copy(copy, original, size);
            }
        }
        private static void TopDownSplitMerge(int[] copy, int start, int end, int[] original)
        {
            if ((end - start) < 2)
                return;
            
            int middle = (start + end) / 2;

            TopDownSplitMerge(original, start, middle, copy);
            TopDownSplitMerge(original, middle, end, copy);
            TopDownMerge(copy, start, middle, end, original);   
        }
        private static void TopDownMerge(int[] copy, int start, int middle, int end, int[] original)
        {
            int i = start;
            int j = middle;

            for (int k = start; k < end; k++)
            {
                if (i < middle && (j >= end || original[i] <= original[j]))
                {
                    copy[k] = original[i++];
                }
                else
                {
                    copy[k] = original[j++];
                }
            }
        }
        private static void BottomUpSplitMerge(int[] original, int[] copy, int length)
        {
            for (int width = 1; width < length; width *= 2)
            {
                for (int i = 0; i < length; i += 2 * width)
                {
                    BottomUpMerge(original, i, Math.Min(i + width, length), Math.Min(i + 2 * width, length), copy);
                }
                Array.Copy(copy, original, length);
            }
        }
        private static void BottomUpMerge(int[] original, int left, int right, int end, int[] copy)
        {
            int i = left, j = right;

            for (int k = left; k < end; k++)
            {
                if (i < right && (j >= end || original[i] <= original[j]))
                {
                    copy[k] = original[i++];
                }
                else
                {
                    copy[k] = original[j++];
                }
            }
        }
    }
}
