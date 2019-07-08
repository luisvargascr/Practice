using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Arrays.MultiDimensionalArrays
{
    public class Exercise01
    {
        public int[,] YearlyBudget = { { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
                                       { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
                                       { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
                                       { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
                                       { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
                                       { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
                                       { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
                                       { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
                                       { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
                                       { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
                                       { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
                                       { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } };

        public Exercise01()
        {
            /* Length is total number of elements in all dimensions */
            var AllLength = YearlyBudget.Length;
            Console.WriteLine(string.Format("Length is {0}", AllLength));

            /* Rank is number of dimensions */
            var Rank = YearlyBudget.Rank;
            Console.WriteLine(string.Format("Rank is {0}", Rank));
            Console.WriteLine();
        }


        public void PrintMatrix()
        {
            for (int rows = 0; rows < YearlyBudget.GetLength(0); rows++)
            {
                for (int cols = 0; cols < YearlyBudget.GetLength(1); cols ++)
                {
                    Console.Write(YearlyBudget[rows, cols] + " ");
                    if (cols == YearlyBudget.GetLength(1) - 1)
                    {
                        Console.Write("\n");
                    }
                }
            }
        }

    } 
}
