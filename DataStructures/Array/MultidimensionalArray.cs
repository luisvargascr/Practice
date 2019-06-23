using System;
namespace DataStructures.Arrays
{
    public class MultidimensionalArray
    {
        public MultidimensionalArray()
        {
            int[,] array2D = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            // The same array with dimensions specified.
            int[,] array2Da = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            // A similar array with string elements.
            string[,] array2Db = { { "one", "two" }, { "three", "four" },
                                        { "five", "six" } };

            // Three-dimensional array.
            int[,,] array3D = { { { 1, 2, 3 }, { 4, 5, 6 } },
                                 { { 7, 8, 9 }, { 10, 11, 12 } } };
            // The same array with dimensions specified.
            int[,,] array3Da = { { { 1, 2, 3 }, { 4, 5, 6 } },
                                       { { 7, 8, 9 }, { 10, 11, 12 } } };

            // Accessing array elements.
            System.Console.WriteLine(array2D[0, 0]);
            System.Console.WriteLine(array2D[0, 1]);
            System.Console.WriteLine(array2D[1, 0]);
            System.Console.WriteLine(array2D[1, 1]);
            System.Console.WriteLine(array2D[3, 0]);
            System.Console.WriteLine(array2Db[1, 0]);
            System.Console.WriteLine(array3Da[1, 0, 1]);
            System.Console.WriteLine(array3D[1, 1, 2]);

            // Getting the total count of elements or the length of a given dimension.
            var allLength = array3D.Length;
            var total = 1;
            for (int i = 0; i < array3D.Rank; i++)
            {
                total *= array3D.GetLength(i);
            }
            System.Console.WriteLine("{0} equals {1}", allLength, total);

        }
        public static void PrintSpiralOrder(int total_rows, int total_cols, int[,] a)
        {
            int index, row = 0, col = 0; 
            /*
                k - starting row index 
                m - ending row index    
                l - starting column index  
                n - ending column index   
                i - iterator 
            */

            while (row < total_rows && col < total_cols)
            {
                // Print the first row  
                // from the remaining rows 
                for (index = col; index < total_cols; ++index)
                {
                    Console.Write(a[row, index] + " ");
                }
                row++;

                // Print the last column from the 
                // remaining columns 
                for (index = row; index < total_rows; ++index)
                {
                    Console.Write(a[index, total_cols - 1] + " ");
                }
                total_cols--;

                // Print the last row from  
                // the remaining rows  
                if (row < total_rows)
                {
                    for (index = total_cols - 1; index >= col; --index)
                    {
                        Console.Write(a[total_rows - 1, index] + " ");
                    }
                    total_rows--;
                }

                // Print the first column from  
                // the remaining columns 
                if (col < total_cols)
                {
                    for (index = total_rows - 1; index >= row; --index)
                    {
                        Console.Write(a[index, col] + " ");
                    }
                    col++;
                }
            }
        }
    }
}
