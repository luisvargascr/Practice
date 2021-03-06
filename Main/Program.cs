﻿using Algorithms;
using BitManipulation;
using DataStructures.Arrays.MultiDimensionalArrays;
using DataStructures.Arrays.OneDimensionalArrays;
using DataStructures.Arrays.Strings;
using DataStructures.BST.Tree;
using DataStructures.Graph;
using DataStructures.Heaps;
using LeetCodePractice;
using System;
using System.Collections.Generic;

namespace Main
{
    class MainClass
    {
        // Constants for the game rules.
        private const int Heigth = 3;
        private const int Width = 4;
        private const uint MaxRuns = 1;

        public static void Main(string[] args)
        {
            MinHeapExercise();
            MaxHeapExercise();
            FindPathBetweenTwoNodes();
            CyclicGraph2();
            NonCyclicGraph();
            CyclicGraph();
            TremauxExecution();
            GermanCities();
            //PrimAlgorithmn();
            /*GraphExecution();
            GermanCities();
            ShortestDistanceBetweenTwoWords();
            StringManip();
            RandomExercises();*/
        }
        private static void MinHeapExercise()
        {
            MinHeap minHeap = new MinHeap(10);
            minHeap.Insert(41);
            minHeap.Insert(90);
            minHeap.Insert(23);
            minHeap.Insert(5);
            minHeap.Insert(14);
            minHeap.Insert(32);
            minHeap.Insert(53);
            minHeap.Insert(50);
            minHeap.Insert(64);
            minHeap.Insert(87);
            minHeap.Print();
            minHeap.Remove();
            minHeap.Print();
            Console.ReadLine();
        }
        private static void MaxHeapExercise()
        {
            MaxHeap maxHeap = new MaxHeap(10);
            maxHeap.Insert(41);
            maxHeap.Insert(90);
            maxHeap.Insert(23);
            maxHeap.Insert(5);
            maxHeap.Insert(14);
            maxHeap.Insert(32);
            maxHeap.Insert(53);
            maxHeap.Insert(50);
            maxHeap.Insert(64);
            maxHeap.Insert(87);
            maxHeap.Print();
            maxHeap.Remove();
            maxHeap.Print();
            Console.ReadLine();
        }
        private static void FindPathBetweenTwoNodes()
        {
            Graph1<int> Graph = new Graph1<int>();
            
            Graph.AddEdge(1, 2, false);
            Graph.AddEdge(2, 3, false);
            Graph.AddEdge(3, 4, false);
            Graph.AddEdge(1, 5, false);
            Graph.AddEdge(5, 6, false);
            Graph.AddEdge(6, 7, false);
            Graph.AddEdge(5, 8, false);
            Graph.AddEdge(1, 9, false);
            Graph.AddEdge(9, 10, false);

            Graph.FindPathBetweenTwoVertices(1, 7);
            Console.ReadLine();
        }
        private static void PrimAlgorithmn()
        {
            List<Vertex> graph = new List<Vertex>();

            Vertex a = new Vertex("A");
            Vertex b = new Vertex("B");
            Vertex c = new Vertex("C");
            Vertex d = new Vertex("D");
            Vertex e = new Vertex("E");

            Edge ab = new Edge(2);
            a.AddEdge(b, ab);
            b.AddEdge(a, ab);
            Edge ac = new Edge(3);
            a.AddEdge(c, ac);
            c.AddEdge(a, ac);
            Edge bc = new Edge(2);
            b.AddEdge(c, bc);
            c.AddEdge(b, bc);
            Edge be = new Edge(5);
            b.AddEdge(e, be);
            e.AddEdge(b, be);
            Edge cd = new Edge(1);
            c.AddEdge(d, cd);
            d.AddEdge(c, cd);
            Edge ce = new Edge(1);
            c.AddEdge(e, ce);
            e.AddEdge(c, ce);

            graph.Add(a);
            graph.Add(b);
            graph.Add(c);
            graph.Add(d);
            graph.Add(e);

            Console.WriteLine("****************");
            Console.WriteLine("\n");
            Prim MyPrimAlgo = new Prim(graph);
            Console.WriteLine("Graph before Prim");
            Console.WriteLine(MyPrimAlgo.OriginalGraphToString());
            Console.ReadLine();
            Console.WriteLine("Graph after Prim");
            MyPrimAlgo.Run();
            MyPrimAlgo.ResetPrintHistory();
            Console.WriteLine(MyPrimAlgo.MinimumSpanningTreeToString());
            Console.WriteLine("****************");
            Console.WriteLine("\n");
            Console.ReadLine();
        }

        private static void RandomExercises()
        {
            int[] numValues = { 8, 1, 2, 2, 3 };
            ArrayExercises.SmallerNumbersThanCurrent(numValues);

            int[] FirstDuplicate = { 2, 1, 3, 5, 3, 2 };
            Console.WriteLine(string.Format("{0} is the first duplicate.", ArrayExercises.FindFirstDuplicate(FirstDuplicate)));

            BinaryTree<int> MyTree = new BinaryTree<int>();

            MyTree.Insert(6);
            MyTree.Insert(7);
            MyTree.Insert(8);
            MyTree.Insert(2);
            MyTree.Insert(7);
            MyTree.Insert(1);
            MyTree.Insert(3);
            MyTree.Insert(9);
            MyTree.Insert(1);
            MyTree.Insert(4);
            MyTree.Insert(5);

            MyTree.SumEvenGrandparent(MyTree.Find(6));

            long binary_val = 100100111000000;
            BitManipulator x = new BitManipulator();
            Console.WriteLine(x.GetDecimalValue(binary_val));

            int[] luis = ManyExercises.BeautifulArray(4);

            int[] arri = { 1, 1, 2, 3, 3, 4, 4, 8, 8 };

            int UniqueVal = ManyExercises.SingleNonDuplicate(arri);

            if (UniqueVal > -1)
                Console.WriteLine(string.Format("Unique value is {0}.", UniqueVal));
            else
                Console.WriteLine("No unique value is found in given array.");

            Console.WriteLine("\n");
            string a = "kqep";
            string b = "pekeq";

            CustomSortString.SortString(a, b);

            int[] Pancakes = { 3, 2, 4, 1 };
            ArrayExercises.PancakeSort(Pancakes);

            // [[11,25,66,1,69,7],[23,55,17,45,15,52],[75,31,36,44,58,8],[22,27,33,25,68,4],[84,28,14,11,5,50]]
            int[][] matrix = new int[5][] { new int[] { 11, 25, 66, 1, 69, 7 }, new int[] { 23, 55, 17, 45, 15, 52 }, new int[] { 75, 31, 36, 44, 58, 8 }, new int[] { 22, 27, 33, 25, 68, 4 }, new int[] { 84, 28, 14, 11, 5, 50 } };

            Console.WriteLine("Original Matrix:");
            PrintMatrix(matrix);
            JaggedArray.DiagonalSort(matrix);
            Console.WriteLine("\nDiagonally Sorted Matrix:");
            PrintMatrix(matrix);
            Console.ReadLine();

            int[] arr = { 8, 3, 2, 7, 9, 1, 4, 1 };

            Console.WriteLine("\n");
            Console.WriteLine("Before SelectionSort:");
            foreach (int i in arr)
            {
                Console.Write(i + ",");
            }
            Console.ReadLine();
            SelectionSortAlgorithm.SelectionSort(arr);

            Console.WriteLine("\n");
            Console.WriteLine("After SelectionSort:");
            foreach (int i in arr)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine("\n");
            Console.ReadLine();

            Console.Write("Binary Search. Enter number to search for: ");
            int.TryParse(Console.ReadLine(), out int key);
            BinarySearchAlgorithm.BinarySearch(arr, key);
            arr = Sorting();

            int[] G = { 1, 2, 3, 3, 4, 5 };
            Console.WriteLine(OneDimensionalArray.FindDuplicate(G));
            Console.ReadLine();

            int[] arrX1 = { 3, 4, -7, 1, 3, 3, 1, -4 };
            OneDimensionalArray.FindSubarrayForGivenSum(arrX1, 7);

            var y1 = new int[] { 3, 1, 7, 5, 4, 9, 2 };
            InsertionSortAlgorithm.InsertionSortBitWise(y1);
            PrintResults(y1);

            //ArrayExercises.StoreElementsInArray();
            var x1 = new int[] { 1, 2, 3 };
            var x2 = new int[] { 1, 2, 3 };
            ArrayExercises.MergeToArraysSameSizeSorted(x1, x2);


            LeetCode lc = new LeetCode();
            var groupSizes = new int[] { 3, 3, 3, 3, 3, 1, 3 };
            var List111 = OneDimensionalArray.GroupThePeople(groupSizes);

            int[][] indices = new int[3][] { new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 } };
            lc.OddCells(2, 3, indices);
        }

        private static void StringManip()
        {
            Console.WriteLine(ManyExercises.FreqAlphabets1("26#11#418#5"));
            Console.WriteLine(ManyExercises.ToLower("MYSTRING"));
            Console.WriteLine(ManyExercises.ToUpper("mystring"));
            Console.WriteLine(ManyExercises.Maximum69Number(6666));
            Console.WriteLine(ManyExercises.Reverse(1534236469));
        }

        private static int[] Sorting()
        {
            int[] arr = new int[] { 8, 3, 2, 7, 9, 1, 4, 1 };
            Console.WriteLine("\n");
            Console.WriteLine("Before HeapSort:");
            foreach (int i in arr)
            {
                Console.Write(i + ",");
            }
            Console.ReadLine();
            HeapSortAlgorithm.HeapSort(arr);

            Console.WriteLine("\n");
            Console.WriteLine("After HeapSort:");
            foreach (int i in arr)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine("\n");
            Console.ReadLine();

            arr = new int[] { 4, 88, 23, 65, 2, 89, 7, 3, 1, 90, 4 };

            Console.WriteLine("\n");
            Console.WriteLine("Before MergeSort:");
            foreach (int i in arr)
            {
                Console.Write(i + ",");
            }
            Console.ReadLine();
            MergeSortAlgorithm.MergeSort(arr, 0, arr.Length - 1);

            Console.WriteLine("\n");
            Console.WriteLine("After MergeSort:");
            foreach (int i in arr)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine("\n");
            Console.ReadLine();

            arr = new int[] { 8, 3, 2, 7, 9, 1, 4, 1 };

            Console.WriteLine("\n");
            Console.WriteLine("Before QuickSort:");
            foreach (int i in arr)
            {
                Console.Write(i + ",");
            }
            Console.ReadLine();
            QuickSortAlgorithm.QuickSort(arr, 0, arr.Length - 1);

            Console.WriteLine("\n");
            Console.WriteLine("After QuickSort:");
            foreach (int i in arr)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine("\n");
            Console.ReadLine();
            return arr;
        }
        private static void ShortestDistanceBetweenTwoWords()
        {
            LinkedInExercise x11 = new LinkedInExercise();
            int c = x11.ReturnValue(4, new List<int> { 5, 8, 9, 44, 1, 23, 3 });

            x11.Configure(new string[] { "The", "Car", "The", "Truck", "Duck", "Duck", "The" });
            var WordOne = "Car";
            var WordTwo = "Truck";
            int index_value = x11.ShortestDistance(WordOne, WordTwo);

            Console.WriteLine(string.Format("{0} is the distance between the words: {1} and {2}", index_value, WordOne, WordTwo));
            Console.ReadLine();
        }
        private static void GermanCities()
        {
            Graph1<string> germanCities = new Graph1<string>();

            germanCities.AddEdge("Frankfurt", "Mannheim", false);
            germanCities.AddEdge("Frankfurt", "Wurzburg", false);
            germanCities.AddEdge("Frankfurt", "Kassel", false);
            germanCities.AddEdge("Mannheim", "Karlsruhe", false);
            germanCities.AddEdge("Karlsruhe", "Augsburg", false);
            germanCities.AddEdge("Augsburg", "Munchen", false);
            germanCities.AddEdge("Wurzburg", "Erfurt", false);
            germanCities.AddEdge("Wurzburg", "Nurnberg", false);
            germanCities.AddEdge("Nurnberg", "Stuttgart", false);
            germanCities.AddEdge("Nurnberg", "Munchen", false);
            germanCities.AddEdge("Kassel", "Munchen", false);

            Console.WriteLine("\n**** DFS Iterative *****");
            germanCities.DFS("Frankfurt");
            Console.WriteLine("--------------");
            Console.WriteLine("\n**** DFS Recursive ****\n");
            germanCities.DFS("Frankfurt", true);
            Console.WriteLine("**************");
            Console.WriteLine();
            Console.WriteLine("**** BFS *****");
            germanCities.BFS("Frankfurt");
            Console.WriteLine("**************");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
            germanCities.FindSpanningTree();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
            germanCities.FindPathBetweenTwoVertices("Frankfurt", "Stuttgart");

            Console.ReadLine();
        }
        private static void NonCyclicGraph()
        {
            Graph1<char> NonCyclic = new Graph1<char>();
            Console.WriteLine("Noncyclic Graph");
            NonCyclic.AddEdge('A', 'B', false);
            NonCyclic.AddEdge('B', 'C', false);
            NonCyclic.AddEdge('C', 'E', false);

            Console.Write("Is it cyclic? ");

            var i = NonCyclic.IsCyclic();
            if (i)
                Console.Write("Yes.");
            else
                Console.Write("No.");

            Console.WriteLine("\nLast Line");
            Console.ReadLine();
        }
        private static void CyclicGraph2()
        {
            Graph1<char> Cyclic = new Graph1<char>();
            Console.WriteLine("Cyclic Graph");
            Cyclic.AddEdge('A', 'B', false);
            Cyclic.AddEdge('B', 'C', false);
            Cyclic.AddEdge('C', 'A', false);
            Cyclic.AddEdge('D', 'C', false);

            Console.Write("Is it cyclic? ");

            var i = Cyclic.IsCyclic();
            if (i)
                Console.Write("Yes.");
            else
                Console.Write("No.");

            Console.WriteLine("\nLast Line");
            Console.ReadLine();
        }
        private static void CyclicGraph()
        {
            Graph1<char> Cyclic = new Graph1<char>();
            Console.WriteLine("Cyclic Graph");
            Cyclic.AddEdge('A', 'B', false);
            Cyclic.AddEdge('B', 'C', false);
            Cyclic.AddEdge('C', 'E', false);
            Cyclic.AddEdge('E', 'F', false);
            Cyclic.AddEdge('F', 'G', false);
            Cyclic.AddEdge('G', 'H', false);
            Cyclic.AddEdge('H', 'A', false);
            Cyclic.AddEdge('A', 'G', false);
            Cyclic.AddEdge('B', 'D', false);
            Cyclic.AddEdge('C', 'D', false);
            Cyclic.AddEdge('E', 'D', false);
            Cyclic.AddEdge('F', 'D', false);
            Cyclic.AddEdge('G', 'D', false);
            Cyclic.AddEdge('H', 'D', false);

            Console.Write("Is it cyclic? ");

            var i = Cyclic.IsCyclic();
            if (i)
                Console.Write("Yes.");
            else
                Console.Write("No.");

            Console.WriteLine("\nLast Line");
            Console.ReadLine();
        }

        private static void TremauxExecution()
        {
            Graph1<char> Tremaux = new Graph1<char>();
            Tremaux.AddEdge('A', 'B', true);
            Tremaux.AddEdge('A', 'C', true);
            Tremaux.AddEdge('A', 'E', true);
            Tremaux.AddEdge('B', 'D', true);
            Tremaux.AddEdge('B', 'F', true);
            Tremaux.AddEdge('C', 'G', true);
            Tremaux.AddEdge('E', 'F', true);

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Printing Whole Graph:\n" + Tremaux.ToString());
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.WriteLine("\n**** DFS iterative ****\n");
            Tremaux.DFS('A');
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\n**** DFS recursive ****\n");
            Tremaux.DFS('A', true);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\n**** BFS ****\n");
            Tremaux.BFS('A');
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\n**** Spanning Tree ****\n");
            Tremaux.FindSpanningTree();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.Write("Is it cyclic? ");
            var i = Tremaux.IsCyclic();
            if (i)
                Console.Write("Yes.");
            else
                Console.Write("No.");
            Console.WriteLine("\nLast Line");
            Console.ReadLine();
        }

        private static void GraphExecution()
        {
            Graph2<string> cities = new Graph2<string>();
            cities.AddVertex("Frankfurt"); //0
            cities.AddVertex("Mannheim"); //1
            cities.AddVertex("Karisruhe"); //2
            cities.AddVertex("Augusburg"); //3
            cities.AddVertex("Munchen"); //4
            cities.AddVertex("Wuzburg"); //5
            cities.AddVertex("Erfurt"); //6
            cities.AddVertex("Numberg"); //7
            cities.AddVertex("Stuttgart"); //8
            cities.AddVertex("Kassel"); //9

            cities.AddEdge(0, 1);
            cities.AddEdge(0, 5);
            cities.AddEdge(0, 9);
            cities.AddEdge(1, 2);
            cities.AddEdge(2, 3);
            cities.AddEdge(3, 4);
            cities.AddEdge(5, 6);
            cities.AddEdge(5, 7);
            cities.AddEdge(8, 7);
            cities.AddEdge(7, 4);
            cities.AddEdge(9, 4);
            Console.WriteLine("\n");
            Console.WriteLine("----- DFS CITIES ------");
            cities.DFS();
            Console.ReadLine();
        }

        private static void PrintMatrix(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                System.Console.Write("Element({0}): ", i);

                for (int j = 0; j < matrix[i].Length; j++)
                {
                    System.Console.Write("{0}{1}", matrix[i][j], j == (matrix[i].Length - 1) ? "" : " ");
                }
                System.Console.WriteLine();
            }
        }

        private static void PrintResults(IEnumerable<int> x)
        {
            Console.WriteLine("\n");
            foreach (int i in x)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
        }

        private static void PrintResults(List<int[]> x)
        {
            if (x.Count > 0)
            {
                Console.Write("[");
                for (int i = 0; i < x.Count; i++)
                {
                    for (int cnt = 0; cnt < x[i].Length; cnt++)
                    {
                        if (cnt == 0)
                            Console.Write("[");
                        if (cnt < x[i].Length - 1)
                            Console.Write(x[i][cnt] + ",");
                        else
                            Console.Write(x[i][cnt] + "]");
                    }
                    if (i < x.Count - 1)
                        Console.Write(",");
                }
                Console.Write("]\n");
            }
        }
    }
}
