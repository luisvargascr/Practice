using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Arrays.MultiDimensionalArrays
{
    public class LeetCode
    {
        public int OddCells (int n, int m, int[][] indices)
        {
            int[,] matrix = new int[n, m];
            var odds = 0;
            foreach (int[] ind in indices)
            {
                for (int i = 0; i < m; i++)
                {
                    matrix[ind[0], i]++;
                }

                for (int i = 0; i < n; i++)
                {
                    matrix[i, ind[1]]++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    odds += matrix[i, j] % 2;
                }
            }

            return odds;
        }
    }
}
