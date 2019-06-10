using System;
namespace Algorithms
{
    public static class MergeSortAlgorithm
    {
        private static void Merge(int[] input, int left, int middle, int right)
        {
            int[] leftArray  = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            Array.Copy(input, left, leftArray, 0, middle - left + 1);
            Array.Copy(input, middle + 1, rightArray, 0, right - middle);

            int left_cnt = 0;
            int right_cnt = 0;

            for (int cnt = left; cnt < right + 1; cnt++)
            {
                if (left_cnt == leftArray.Length)
                {
                    input[cnt] = rightArray[right_cnt];
                    right_cnt++;
                }
                else if (right_cnt == rightArray.Length)
                {
                    input[cnt] = leftArray[left_cnt];
                    left_cnt++;
                }
                else if (leftArray[left_cnt] <= rightArray[right_cnt])
                {
                    input[cnt] = leftArray[left_cnt];
                    left_cnt++;
                }
                else
                {
                    input[cnt] = rightArray[right_cnt];
                    right_cnt++;
                }
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
    }
}
