namespace DataStructures.Arrays.OneDimensionalArrays
{
    public static class MergeArraysExercise
    {
        /*
            x = first array
            y = second array
            m = counter numbers other than zero
            n = size of y minus one
             
        */
        private static void Merge(int[] x, int[] y, int m, int n)
        {
            int k = m + n + 1;

            while (m >= 0 && n >= 0)
            {
                if (x[m] > y[n])
                    x[k--] = x[m--];
                else
                    x[k--] = y[n--];
            }
            while (n >= 0)
            {
                x[k--] = y[n--];
            }
        }

        public static void Rearrange(int[]x, int[]y)
        {
            int k = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] != 0)
                {
                    x[k++] = x[i];
                }
            }
            Merge(x, y, k - 1, y.Length - 1);
        }
    }
}
