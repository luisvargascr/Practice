using System;
namespace DataStructures.Arrays.OneDimensionalArrays
{
    public static class Exercises1
    {
        public static int MaxSum(int[] arr, int n, int k)
        {
            int max_sum = int.MinValue;

            for (int i = 0; i < n - k + 1; i++)
            {
                int current_sum = 0;
                for (int j = 0; j < k; j++)
                {
                    current_sum = current_sum + arr[i + j];
                }
                max_sum = Math.Max(current_sum, max_sum);
            }
            return max_sum;
        }
        public static int SlidingWindowMaxsum(int[] arr, int n, int k)
        {
            if (n < k)
            {
                Console.WriteLine("Invalid");
                return -1;
            }

            /* Compute sum of first window of size k */

            int max_sum = 0;
            for (int i = 0; i < k; i++)
            {
                max_sum += arr[i];
            }

            /* Compute sum of remaining windows by
               removing first element of previous window
               and adding last element of current window.
            
             [1,4,2,10,2,3,1,0,20]

             [1,4,2,10] 
               [4,2,10,2] ============> (2 - 1)  =   1
                 [2,10,2,3] ==========> (3 - 4)  =  -1
                   [10,2,3,1] ========> (1 - 2)  =  -1
                      [2,3,1,0] ======> (0 - 10) = -10
                        [3,1,0,20] ===> (20-2)   =  18
            
             */

            int window_sum = max_sum;
            for (int i = k; i < n; i++)
            {
                // arr[i]     => last element of current window.
                // arr[i - k] => first element of previous window.

                window_sum += arr[i] - arr[i - k];
                max_sum = Math.Max(max_sum, window_sum);
            }

            return max_sum;
        }
        public static bool BinarySearch(int[] arr, int value)
        {
            int l = 0, r = arr.Length - 1;

            while (l <= r)
            {
                int m = l + (r - l) / 2;

                if (arr[m] == value)
                    return true;
                if (arr[m] < value)
                    l = m + 1;
                else
                    r = m - 1;
            }

            return false;
        }

        public static bool TwoPointerTechniqueIsPairSum (int[] a, int n, int value)
        {
            int i = 0;
            int j = n - 1;

            while (i < j)
            {
                if (a[i] + a[j] == value)
                    return true;
                else if (a[i] + a[j] < value)
                    i++;
                else
                    j--;
            }
            return false;
        }

        public static void ReverseArray(int[] arr)
        {
            for (int i = 0, j = arr.Length - 1; i < j; i++, j--)
            {
                int tmp = arr[i];
                arr[i] = arr[j];
                arr[j] = tmp;
            }
        }
        public static void Reverse(int[] arr, int i, int j)
        {
            int s = i, e = j;

            while (s < e)
            {
                int tmp = arr[s];
                arr[s] = arr[e];
                arr[e] = tmp;
                s++;
                e--;
            }
        }
        public static void Rotate(int[] arr, int d)
        {
            Reverse(arr, 0, d - 1);
            Reverse(arr, d, arr.Length - 1);
            Reverse(arr, 0, arr.Length - 1);
        }
        private static int GDC(int a, int b)
        {
            if (b == 0)
                return a;
            return GDC(a, a % b);
        }
        public static void JugglingAlgorithmRotate(int[] arr, int d, int n)
        {
            d = d % n;
            int g = GDC(d, n);

            for (int i = 0; i < g; i++)
            {
                int temp = arr[i];
                int j = i;
                while (true)
                {
                    int k = j + d;
                    if (k >= n)
                        k = k - n;

                    if (k == i)
                        break;

                    arr[j] = arr[k];
                    j = k;
                }
                arr[j] = temp;
            }
        }
    }
}
