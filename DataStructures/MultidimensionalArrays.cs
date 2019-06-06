using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class MultidimensionalArrays
    {
        // array[rows,columns]
        private int[,] _array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
        private int[,] _array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

        private string[,] array2Db = new string[3, 2] { { "one", "two" }, { "three", "four" }, { "five", "six" } };
        private int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } }, {{ 7, 8, 9 }, { 10, 11, 12 } }};

        int[,,] array3Da = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                       { { 7, 8, 9 }, { 10, 11, 12 } } };

        int[,] array4 = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

       
        public MultidimensionalArrays()
        {

            HashSet<int> MyHash = new HashSet<int>();
            MyHash.Add(1);
            MyHash.Add(1);
            MyHash.Add(2);

            foreach (int x in MyHash)
            {
                Console.WriteLine(x);
            }



            for (int row = 0; row < array4.GetLength(0); row++)
            {
                for (int col = 0; col < array4.GetLength(1); col++)
                {
                    Console.Write(array4[row, col] + ",");
                }
            }
            Console.WriteLine("\n");

            System.Console.WriteLine(_array2D[0, 0]);
            System.Console.WriteLine(_array2D[0, 1]);
            System.Console.WriteLine(_array2D[1, 0]);
            System.Console.WriteLine(_array2D[1, 1]);
            System.Console.WriteLine(_array2D[3, 0]);
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
    }
}
