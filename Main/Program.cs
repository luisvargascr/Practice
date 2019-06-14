using System;
using DataStructures;
using Algorithms;
using DataStructures.LinkedList;
using DataStructures.Stack;
using DataStructures.Queue;
using DataStructures.BST.Tree;
using LeetCodePractice;
using CareerCup;
using HackerRank;
using System.Collections.Generic;
using DataStructures.Graph;

namespace Main
{
    class MainClass
    {
        public static void Main(string[] args)
        {
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
