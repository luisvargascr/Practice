using Algorithms;
using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCodePractice
{
    public static class TwoDArray
    {
        public static int[][] DiagonalSort(int[][] mat)
        {

            for (int col = 0; col < mat.Length; col++)
            {
                List<int> tmp = new List<int>();
                for (int row = 0; row < mat[col].Length - 1; row++)
                {
                    tmp.Add(mat[row][col]);
                }
                int[] arr = tmp.ToArray();
                Array.Sort(arr);

                for (int row = 0; row < mat[col].Length - 1; row++)
                    mat[col][row] = arr[row];
            }
            return mat;
        }
    }
}
