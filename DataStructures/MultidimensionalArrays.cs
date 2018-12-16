using System;
namespace DataStructures
{
    public class MultidimensionalArrays
    {
        // array[rows,columns]
        private int[,] _array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
        private int[,] _array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

        private string[,] array2Db = new string[3, 2] { { "one", "two" }, { "three", "four" }, { "five", "six" } };
        private int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } }, {{ 7, 8, 9 }, { 10, 11, 12 } }};


        public MultidimensionalArrays()
        {
            System.Console.WriteLine(_array2D[0, 0]);
            System.Console.WriteLine(_array2D[0, 1]);
            System.Console.WriteLine(_array2D[1, 0]);
            System.Console.WriteLine(_array2D[1, 1]);
            System.Console.WriteLine(_array2D[3, 0]);
            
        }
    }
}
