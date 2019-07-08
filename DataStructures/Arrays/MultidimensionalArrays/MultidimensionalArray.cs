using System;
namespace DataStructures.Arrays.MultiDimensionalArrays
{
    public class MultiDimensionalArray
    {
        public MultiDimensionalArray()  
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
    public class LifeSimulation
    {
        private int Heigth;
        private int Width;
        private bool[,] cells;

        /// <summary>
        /// Initializes a new Game of Life.
        /// </summary>
        /// <param name="Heigth">Heigth of the cell field.</param>
        /// <param name="Width">Width of the cell field.</param>

        public LifeSimulation(int Heigth, int Width)
        {
            this.Heigth = Heigth;
            this.Width = Width;
            cells = new bool[Heigth, Width];
            GenerateField();
        }

        /// <summary>
        /// Advances the game by one generation and prints the current state to console.
        /// </summary>
        public void DrawAndGrow()
        {
            //DrawGame();
            Grow();
            DrawGame();
        }

        /// <summary>
        /// Advances the game by one generation according to GoL's ruleset.
        /// </summary>

        private void Grow()
        {
            for (int i = 0; i < Heigth; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    int numOfAliveNeighbors = GetNeighbors(i, j);

                    if (cells[i, j])
                    {
                        if (numOfAliveNeighbors == 2 ||
                            numOfAliveNeighbors == 3)
                        {
                            cells[i, j] = true;
                        }
                        else
                        {
                            cells[i, j] = false;
                        }
                    }
                    else
                    {
                        if (numOfAliveNeighbors == 3)
                        {
                            cells[i, j] = true;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Checks how many alive neighbors are in the vicinity of a cell.
        /// </summary>
        /// <param name="x">X-coordinate of the cell.</param>
        /// <param name="y">Y-coordinate of the cell.</param>
        /// <returns>The number of alive neighbors.</returns>

        private int GetNeighbors(int x, int y)
        {
            int NumOfAliveNeighbors = 0;

            for (int i = x - 1; i < x + 2; i++)
            {
                for (int j = y - 1; j < y + 2; j++)
                {
                    if (!((i < 0 || j < 0) || (i >= Heigth || j >= Width)))
                    {
                        if (!((i == x) && (j == y)))
                        {
                            if (cells[i, j] == true) NumOfAliveNeighbors++;
                        }
                    }
                }
            }
            return NumOfAliveNeighbors;
        }

        /// <summary>
        /// Draws the game to the console.
        /// </summary>

        private void DrawGame()
        {
            for (int i = 0; i < Heigth; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Console.Write(cells[i, j] ? "o" : "x");
                    if (j == Width - 1) Console.WriteLine("\r");
                }
            }
            //Console.SetCursorPosition(0, Console.WindowTop);
        }

        /// <summary>
        /// Initializes the field with random boolean values.
        /// </summary>

        private void GenerateField()
        {
            cells[0, 0] = true;   // o
            cells[0, 1] = false;  // x
            cells[0, 2] = true;   // o
            cells[0, 3] = false;  // x

            cells[1, 0] = false;  // x
            cells[1, 1] = true;   // o
            cells[1, 2] = true;   // o
            cells[1, 3] = false;  // x

            cells[2, 0] = true;   // o
            cells[2, 1] = false;  // x
            cells[2, 2] = false;  // x
            cells[2, 3] = true;   // o

            Console.WriteLine("Drawing Board First Time");
            Console.WriteLine();
            DrawGame();
            Console.WriteLine();
            Console.WriteLine("Drawing Board Second Time");



            /*Random generator = new Random();
            int number;
            for (int i = 0; i < Heigth; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    number = generator.Next(2);
                    cells[i, j] = ((number == 0) ? false : true);
                }
            }*/
        }
    }
}
