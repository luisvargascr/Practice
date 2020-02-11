using System.Collections.Generic;

namespace DataStructures.Arrays.MultiDimensionalArrays
{
    public static class JaggedArray
    {
        public static int[][] DiagonalSort(int[][] mat)
        {
<<<<<<< HEAD
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
=======
            int total_dimensions = mat.Length;
            int total_columns = mat[0].Length;
            int current_dimension = total_dimensions - 1;
            int current_column = 0;
            int index = 0;

            // This sorts 2D grid bottom-up, left-to-right.
            while (current_dimension >= 0)
>>>>>>> 54a65d0126658e60685e222d615efec0acfd55ca
            {
                List<int> tmp_list = new List<int>();
                index = 0;

<<<<<<< HEAD
                for (int i = 0; dim_cnt + i < total_dimensions && column + i < total_rows; i++)
                    arr.Add(mat[dim_cnt + i][column + i]);
=======
                while (current_dimension + index < total_dimensions && current_column + index < total_columns)
                {
                    int num = mat[current_dimension + index][current_column + index];
                    tmp_list.Add(num);
                    index++;
                }
                tmp_list.Sort();
>>>>>>> 54a65d0126658e60685e222d615efec0acfd55ca

                index = 0;

<<<<<<< HEAD
                for (int i = 0; dim_cnt + i < total_dimensions && column + i < total_rows; i++)
                    mat[dim_cnt + i][column + i] = arr[i];
=======
                while (current_dimension + index < total_dimensions && current_column + index < total_columns)
                {
                    mat[current_dimension + index][current_column + index] = tmp_list[index];
                    index++;
                }
                current_dimension--;
>>>>>>> 54a65d0126658e60685e222d615efec0acfd55ca
            }

            current_dimension = 0;
            current_column = 1;

            // This sorts 2D grid top-to-bottom, left-to-right.
            while (current_column < total_columns - 1)
            {
                List<int> tmp_list = new List<int>();
                index = 0;

                while (current_dimension + index < total_dimensions && current_column + index < total_columns)
                {
                    int num = mat[current_dimension + index][current_column + index];
                    tmp_list.Add(num);
                    index++;
                }
                tmp_list.Sort();
                index = 0;

                while (current_dimension + index < total_dimensions && current_column + index < total_columns)
                {
                    mat[current_dimension + index][current_column + index] = tmp_list[index];
                    index++;
                }
                current_column++;
            }
            return mat;
        }
    }
}
