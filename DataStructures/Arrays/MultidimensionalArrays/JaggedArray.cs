using System.Collections.Generic;

namespace DataStructures.Arrays.MultiDimensionalArrays
{
    public static class JaggedArray
    {
        public static int[][] DiagonalSort(int[][] mat)
        {

            int total_dimensions = mat.Length;
            int total_columns = mat[0].Length;
            int current_dimension = total_dimensions - 1;
            int current_column = 0;
            int index = 0;

            // This sorts 2D grid bottom-up, left-to-right.
            while (current_dimension >= 0)
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
                current_dimension--;
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
