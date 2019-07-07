﻿using System;
using System.Collections.Generic;
using DataStructures.Graph;
using System.Linq;
using DataStructures.Arrays.MultiDimensionalArrays;
using DataStructures.Arrays.OneDimensionalArrays;

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
            int runs = 0;
            
            LifeSimulation sim = new LifeSimulation(Heigth, Width);

            while (runs++ < MaxRuns)
            {
                sim.DrawAndGrow();

                // Give the user a chance to view the game in a more reasonable speed.
                System.Threading.Thread.Sleep(100);
            }
            Console.ReadLine();

            int[] first_array = { 1, 4, 7, 8, 10 };
            int[] second_array = { 2, 3, 9 };

            OneDimensionalArray.MergeTwoArrays(first_array, second_array);
            Console.WriteLine("First Array: ");
            foreach (int i in first_array)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine("\nSecond Array: ");
            foreach (int i in second_array)
            {
                Console.Write(i + ",");
            }
            Console.ReadLine();


            int[] BinArray = { 0, 0, 1, 0, 1, 0, 0 };
            int[] Consecutives = { 2, 0, 2, 1, 4, 3, 1, 0 };
            int[] MaxLength = { 5,6,-5,5,3,5,3,-2,0 };
            int[] ThreeWay = { 0, 1, 2, 2, 1, 0, 0, 2, 0, 1, 1, 0 };

            OneDimensionalArray.ThreeWayPartition(ThreeWay, ThreeWay.Length - 1);
            foreach (int i in ThreeWay)
            {
                Console.Write(i + ",");
            }
            Console.ReadLine();

            OneDimensionalArray.MaxLengthSubArrayBinary(BinArray);
            Console.ReadLine();

            OneDimensionalArray.MaxLengthSubArray(MaxLength, 8);
            Console.ReadLine();

            OneDimensionalArray.FindMaxSubArray(Consecutives);

            Console.ReadLine();



            var x12 = CodeChef.EasyCodeChef.DecrementOrIncrement(5);
            Console.WriteLine(x12);
            var x22 = CodeChef.EasyCodeChef.DecrementOrIncrement(8);
            Console.WriteLine(x22);
            Console.ReadLine();

            int[] duplicate_array = { 1,2,3,4,4 };
            OneDimensionalArray.FindDuplicateItem(duplicate_array);
            Console.ReadLine();
        
            int[] binary_array = { 1,0,1,0,1,0,0,1 };

            OneDimensionalArray.SortBinaryArray(binary_array);
            Console.ReadLine();

            int R = 3;
            int C = 6;
            int[,] array = { {  1,  2,  3,  4,  5,  6 },
                             {  7,  8,  9, 10, 11, 12 },
                             { 13, 14, 15, 16, 17, 18 } };




            MultiDimensionalArray.PrintSpiralOrder(R,C,array);
            Console.ReadLine();

            int[] arr8 = { 0,0,0,0,4,5,6,7 };
            IEnumerable<int> ah = OneDimensionalArray.PlusOne(arr8.ToList());

            foreach (int i in ah)
            {
                Console.Write(i + " ");
            }


            Console.ReadLine();

            int[] arr0 = { 8, 7, 2, 5, 3, 1 };
            OneDimensionalArray.FindPairNLogN(arr0, 10);
            int[] zarr = { 4, 2, -3, -1, 0, 4};
            //Console.WriteLine(string.Format("Can you add zero? {0}.",DataStructures.Arrays.OneDimensionalArray.ZeroSumSubarray(zarr) ? "Yes" : "No"));
            OneDimensionalArray.PrintAllSubarrays(zarr);
            Console.ReadLine();
            
            int[] arr1 = { 7,1,3,2,4,5,6 };
            int[] arr2 = { 4,3,1,2 };
            int[] arr3 = { 2, 3, 4, 1, 5 };
            int[] arr4 = { 1,3,5,2,4,6,7 };


            int x1 = HackerRank.ArrayExercises.MinimumSwaps(arr1);
            int x2 = HackerRank.ArrayExercises.MinimumSwaps(arr2);
            int x3 = HackerRank.ArrayExercises.MinimumSwaps(arr3);
            int x4 = HackerRank.ArrayExercises.MinimumSwaps(arr4);


            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(x3);
            Console.WriteLine(x4);
            Console.ReadLine();
            //HackerRank.ArrayExercises.MinimumBribes(arr);

            //Graph grapho = new Graph();

            //Vertex vertexLuis = new Vertex
            //{
            //    Name = "Luis"
            //};
            //Vertex vertexKitt = new Vertex
            //{
            //    Name = "Kitt"
            //};
            //Vertex vertexCarlos = new Vertex
            //{
            //    Name = "Carlos"
            //};
            //Vertex vertexJuan = new Vertex
            //{
            //    Name = "Juan"
            //};
            //Vertex vertexJohn = new Vertex
            //{
            //    Name = "John"
            //};

            //vertexLuis.Nodes.Add(vertexKitt);
            //vertexLuis.Nodes.Add(vertexCarlos);
            //vertexLuis.Nodes.Add(vertexJuan);

            //vertexKitt.Nodes.Add(vertexLuis);
            //vertexKitt.Nodes.Add(vertexCarlos);
            //vertexKitt.Nodes.Add(vertexJuan);

            //vertexCarlos.Nodes.Add(vertexKitt);
            //vertexCarlos.Nodes.Add(vertexLuis);
            //vertexCarlos.Nodes.Add(vertexJuan);

            //vertexJuan.Nodes.Add(vertexLuis);
            //vertexJuan.Nodes.Add(vertexCarlos);

            //grapho.Vertices.Add(vertexJuan);
            //grapho.Vertices.Add(vertexCarlos);
            //grapho.Vertices.Add(vertexLuis);
            //grapho.Vertices.Add(vertexKitt);

            ////grapho.DepthFirstSearch(vertexJuan, 1);
            ////grapho.DepthFirstSearchNR(vertexLuis);
            ////grapho.BreadthFirstSearchNR(vertexLuis);

            //bool x1 = grapho.RouteBetweenNodes(vertexLuis, vertexJohn);
            ////bool x2 = grapho.RouteBetweenNodes(vertexCarlos, vertexJuan);

            //Console.ReadLine();

            Vertex a = new Vertex
            {
                Name = "a"
            };
            Vertex b = new Vertex
            {
                Name = "b"
            };
            Vertex c = new Vertex
            {
                Name = "c"
            };
            Vertex d = new Vertex
            {
                Name = "d"
            };
            Vertex e = new Vertex
            {
                Name = "e"
            };
            Vertex f = new Vertex
            {
                Name = "f"
            };

            a.Nodes.Add(d);
            //d.Nodes.Add(a);
            f.Nodes.Add(b);
            b.Nodes.Add(d);
            f.Nodes.Add(a);
            d.Nodes.Add(c);
            

            Graph n = new Graph();
            n.Vertices.Add(a);
            n.Vertices.Add(b);
            n.Vertices.Add(c);
            n.Vertices.Add(d);
            n.Vertices.Add(e);
            n.Vertices.Add(f);

            try
            {
                n.TopologicalSort(); 
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();


            //int[] a = { 1, 5, 2, 6, 3, 7 };
            //int[] b = { 5, 6, 7, 1, 2, 3 };

            //List<int[]> x = Exercise1.FindSubstringLocation("BCXXBXXCXDXBCD", "BCD");
            //PrintResults(x);
            //Console.WriteLine("\n");
            //List<int[]> y = Exercise1.FindSubstringLocation("BCXXBXCXBCBC", "BCBC");
            //PrintResults(y);

            //int[] s = { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            //int FinalResult = WarmUp.SockMerchant(9, s);
            //Console.WriteLine(FinalResult);

            //string v = "UDDDUDUU";

            //int FinalOutput = WarmUp.CountingValleys(8, v);


            //int[] arr = { 88, 23, 65, 2, 89, 7, 3, 1, 90, 4 };

            //Console.WriteLine("\n");
            //Console.WriteLine("Before MergeSort:");
            //foreach (int i in arr)
            //{
            //    Console.Write(i + ",");
            //}

            //MergeSortAlgorithm.MergeSort(arr, 0, arr.Length - 1);

            //Console.WriteLine("\n");
            //Console.WriteLine("After MergeSort:");
            //foreach (int i in arr)
            //{
            //    Console.Write(i + ",");
            //}
            //Console.WriteLine("\n");

            //int[] c = { 0,0,1,0,0,1,0 };


            //int val = WarmUp.JumpingOnClouds(c);
            //Console.WriteLine(val);
            //Console.WriteLine("\n");

            ////Console.WriteLine("Before QuickSort");
            ////Console.WriteLine("\n");
            ////foreach (int i in arr)
            ////{
            ////    Console.Write(i + ",");
            ////}

            ////QuickSortAlgorithm.QuickSort(arr, 0, arr.Length - 1);

            ////Console.WriteLine("\n");
            ////Console.WriteLine("After QuickSort");
            ////foreach (int i in arr)
            ////{
            ////    Console.Write(i + ",");
            ////}

            ////MultidimensionalArrays mda = new MultidimensionalArrays();
            ///* SolutionOne NewSolution = new SolutionOne();


            // int[][] edges = { new int[] { 1, 0 }, 
            //                   new int[] { 1, 2 }, 
            //                   new int[] { 1, 3 } };

            // NewSolution.FindMinHeightTrees(4,edges);
            // */

            ////FindMissingElement x = new FindMissingElement();

            ////int[] a1 = { 4, 12, 9, 5, 6 };
            ////int[] a2 = { 4, 9, 12, 6 };

            ////int y = x.FindMissingElementXor(a1, a2);
            ////int z = x.FindCommonElementAnd(a1, a2);

            ////Console.WriteLine(string.Format("'{0}' was the missing element in the array.", y));
            ////Console.WriteLine(string.Format("'{0}' were the common elements in the array", z));

            ////NewSolution.TwoSum(Nums, Target);



            ///*BinaryTree<int> BTree = new BinaryTree<int>();
            //BTree.Insert(100);
            //BTree.Insert(7);
            //BTree.Insert(10);
            //BTree.Insert(101);
            //BTree.Insert(105);
            //var Root = BTree.Find(100);
            //BTree.InOrder(Root);

            //Console.ReadLine();


            //SinglyLinkedList<int> SinglyLinkedListObj1 = new SinglyLinkedList<int>();
            //SinglyLinkedListObj1.AddToBeginning(1);
            //SinglyLinkedListObj1.AddToBeginning(2);
            //SinglyLinkedListObj1.AddToBeginning(3);

            //SinglyLinkedListObj1.DisplaySinglyLinkedList();

            //SinglyLinkedList<int> SinglyLinkedListObj2 = new SinglyLinkedList<int>();
            //SinglyLinkedListObj2.AddToEnd(1);
            //SinglyLinkedListObj2.AddToEnd(2);
            //SinglyLinkedListObj2.AddToEnd(3);
            //SinglyLinkedListObj2.AddToEnd(2);
            //SinglyLinkedListObj2.AddToEnd(2);
            //SinglyLinkedListObj2.AddToEnd(1);

            //SinglyLinkedListObj2.DisplaySinglyLinkedList();

            ////SinglyLinkedListObj2.DeleteNode(2);
            ////SinglyLinkedListObj2.DeleteFromBeginning();
            //SinglyLinkedListObj2.DeleteFromEnd();

            //SinglyLinkedListObj2.DisplaySinglyLinkedList();
            //SinglyLinkedListObj2.FindItem(97);
            //SinglyLinkedListObj2.FindItem(1);
            //SinglyLinkedListObj2.DeleteFromBeginning();
            //SinglyLinkedListObj2.FindItem(1);

            //Console.WriteLine("----------------------");
            //Console.WriteLine("--- STACK ---");

            //LLStack<int> SimpleStack = new LLStack<int>();
            //SimpleStack.Push(20);
            //SimpleStack.Push(40);

            //SimpleStack.DisplayStack();

            //SimpleStack.Push(60);
            //SimpleStack.Push(80);

            //SimpleStack.DisplayStack();
            //SimpleStack.Pop();
            //SimpleStack.Pop();
            //SimpleStack.DisplayStack();

            //Console.WriteLine("----------------------");
            //Console.WriteLine("--- QUEUE ---");

            //LLQueue<int> SimpleQueue = new LLQueue<int>();
            //SimpleQueue.Enqueue(20);
            //SimpleQueue.Enqueue(40);

            //SimpleQueue.DisplayQueue();

            //SimpleQueue.Enqueue(60);
            //SimpleQueue.Enqueue(80);

            //SimpleQueue.DisplayQueue();

            //SimpleQueue.Dequeue();
            //SimpleQueue.Dequeue();

            //SimpleQueue.DisplayQueue();

            //Console.WriteLine("----------------------");
            //Console.ReadLine();*/
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
