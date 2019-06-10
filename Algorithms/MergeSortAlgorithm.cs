using System;
namespace Algorithms
{
    public static class MergeSortAlgorithm
    {
        private static void Merge(int[] input, int left, int middle, int right)
        {
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            Array.Copy(input, left, leftArray, 0, middle - left + 1);
            Array.Copy(input, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;

            for (int cnt = left; cnt < right + 1; cnt++)
            {
                if (i == leftArray.Length)
                {
                    input[cnt] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    input[cnt] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    input[cnt] = leftArray[i];
                    i++;
                }
                else
                {
                    input[cnt] = rightArray[j];
                    j++;
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
