namespace Algorithms
{
    public static class SelectionSortAlgorithm
    {
        // Time  = O(n^2)
        // Space = O(n)

        public static void SelectionSort(int[] arr)
        {
            int temp, smallest;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                smallest = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = arr[smallest];
                arr[smallest] = arr[i];
                arr[i] = temp;
            }
        }
    }
}
