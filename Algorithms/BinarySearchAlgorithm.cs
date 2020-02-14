using System;

namespace Algorithms
{
    /* Binary Search assumes that input array is already sorted out. */
    public static class BinarySearchAlgorithm
    {
        public static void BinarySearch(int[] arr, int key)
        {
            int Min = 0;
            int Max = arr.Length - 1;

            while (Min <= Max)
            {
                int Mid = (Min + Max) / 2;

                if (key == arr[Mid])
                {
                    Console.WriteLine(string.Format("{0} found at position {1} in array.", arr[Mid], ++Mid));
                    return;
                }
                else if (key < arr[Mid])
                    Max = Mid - 1;
                else
                    Min = Mid + 1;
            }
            Console.WriteLine("Item not found.");
        }
    }
}
