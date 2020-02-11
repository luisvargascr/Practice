using System;
using System.Collections.Generic;

namespace DataStructures.Arrays.MultiDimensionalArrays
{
    public static class JaggedArray
    {
        public static int[][] DiagonalSort(int[][] mat)
        {
            int total_dimensions = mat.Length, total_rows = mat[0].Length;

            for (int dim_cnt = total_dimensions - 1, column = 0; dim_cnt >= 0; dim_cnt--)
            {
                List<int> arr = new List<int>();

                for (int i = 0; dim_cnt + i < total_dimensions && column + i < total_rows; i++)
                    arr.Add(mat[dim_cnt + i][column + i]);

                arr.Sort();

                for (int i = 0; dim_cnt + i < total_dimensions && column + i < total_rows; i++)
                    mat[dim_cnt + i][column + i] = arr[i];
            }
            //FillMatrix(mat, dimension, row, dim_cnt, column);

            for (int dim_cnt = 0, column = 1; column < total_rows - 1; column++)
            {
                List<int> arr = new List<int>();

                for (int i = 0; dim_cnt + i < total_dimensions && column + i < total_rows; i++)
                    arr.Add(mat[dim_cnt + i][column + i]);

                arr.Sort();

                for (int i = 0; dim_cnt + i < total_dimensions && column + i < total_rows; i++)
                    mat[dim_cnt + i][column + i] = arr[i];
            }
                //FillMatrix(mat, dimension, row, dim_cnt, column);

            return mat;
        }
        private static void FillMatrix(int[][] mat, int dimension, int row, int dim_cnt, int column)
        {
            List<int> arr = new List<int>();

            for (int i = 0; dim_cnt + i < dimension && column + i < row; i++)
                arr.Add(mat[dim_cnt + i][column + i]);

            arr.Sort();

            for (int i = 0; dim_cnt + i < dimension && column + i < row; i++)
                mat[dim_cnt + i][column + i] = arr[i];
        }
        public static int[][] DiagonalSort2(int[][] mat)
        {
            // int[] r1 = new int[] { 3, 3, 1, 1 }
            // int[] r2 = new int[] { 2, 2, 1, 2 }
            // int[] r3 = new int[] { 1, 1, 1, 2 }

            // 3, 3, 1, 1
            // 2, 2, 1, 2
            // 1, 1, 1, 2

            // 1, 1, 1, 1
            // 2, 2, 1, 2 ==> First Order Columns
            // 3, 3, 1, 2

            // 1, 1, 1, 1
            // 1, 2, 2, 2 ==> Then Order Rows
            // 1, 2, 3, 3

            int dimension = 0;
            int row = 0;
            int col = 0;

            int new_dimension = 0;
            int new_col = 0;
            int i = 0;
            List<int> tmp = new List<int>();

            while (dimension < mat.Length)
            {
                while (col < mat[dimension].Length)
                {
                    tmp.Clear();
                    while (new_dimension < mat.Length)
                    {
                        int item = mat[new_dimension][i];
                        tmp.Add(item);
                        new_dimension++;
                        new_col++;
                    }
                    tmp.Sort();

                    new_dimension = 0;
                    new_col = col;
                    i = 0;

                    while (new_dimension < mat.Length)
                    {
                        mat[new_dimension][new_col] = tmp[i];
                        new_dimension++;
                        i++;
                    }
                    new_dimension = 0;
                    new_col++;
                    col++;
                    i = col;
                }
                dimension++;
            }
            for (int dim = 0; dim < mat.Length; dim++)
            {
                int[] r = mat[dim];
                Array.Sort(r);
                mat[dim] = r;
            }
            return mat;
        }
    }
}
