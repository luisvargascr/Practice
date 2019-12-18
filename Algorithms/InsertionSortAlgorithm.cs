namespace Algorithms
{
    public static class InsertionSortAlgorithm
    {
        public static void InsertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int tmp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
        }
        public static void InsertionSortBitWise(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        arr[j - 1] = arr[j - 1] ^ arr[j];
                        arr[j] = arr[j - 1] ^ arr[j];
                        arr[j - 1] = arr[j - 1] ^ arr[j];
                    }
                }
            }
        }

    }
}
