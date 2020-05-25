using Algorithms;
using BitManipulation;
using DataStructures.Arrays.MultiDimensionalArrays;
using DataStructures.Arrays.OneDimensionalArrays;
using DataStructures.Arrays.Strings;
using DataStructures.BST.Tree;
using DataStructures.Graph;
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
            Console.WriteLine("************");
            Graph2<int> mygraph = new Graph2<int>();

            mygraph.AddEdge(0, 1, true);
            mygraph.AddEdge(0, 4, true);
            mygraph.AddEdge(1, 2, true);
            mygraph.AddEdge(1, 3, true);
            mygraph.AddEdge(1, 4, true);
            mygraph.AddEdge(2, 3, true);
            mygraph.AddEdge(3, 4, true);

            Console.WriteLine("Graph:\n" + mygraph.ToString());

            mygraph.GetVertexCount();
            mygraph.GetEdgesCount(true);
            mygraph.HasEdge(3, 4);
            mygraph.HasVertex(5);

            Console.WriteLine("************");
            Console.ReadLine();
          
            // 9,15,1,3,5

            LinkedInExercise x11 = new LinkedInExercise();
            int c = x11.ReturnValue(4, new List<int> { 5, 8, 9, 44, 1, 23, 3 });


            x11.Configure(new string[] { "The", "Car", "The", "Truck", "Duck", "Duck", "The" });
            var WordOne = "Car";
            var WordTwo = "Truck";
            int index_value = x11.ShortestDistance(WordOne,WordTwo);

            Console.WriteLine(string.Format("{0} is the distance between the words: {1} and {2}", index_value, WordOne, WordTwo));
            Console.ReadLine();

            Console.WriteLine(ManyExercises.FreqAlphabets1("26#11#418#5"));
            Console.ReadLine();

            Console.WriteLine(ManyExercises.ToLower("MYSTRING"));
            Console.WriteLine(ManyExercises.ToUpper("mystring"));
            Console.ReadLine();

            Console.WriteLine(ManyExercises.Maximum69Number(6666));
            Console.ReadLine();
            Console.WriteLine(ManyExercises.Reverse(1534236469));
            int[] numValues = { 8, 1, 2, 2, 3 };
            ArrayExercises.SmallerNumbersThanCurrent(numValues);

            int[] FirstDuplicate = { 2,1,3,5,3,2 };
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

            arr = new int[] { 8, 3, 2, 7, 9, 1, 4, 1 };

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


            //BitManipulator BitMan = new BitManipulator();

            //int Missing = BitMan.MissingNumber(new List<int>() { 1, 2, 4, 5, 6, 7 });

            //int Insertion = BitMan.BitInsertion(1024, 19, 2, 6);
            //Console.WriteLine(string.Format("Insertion value = {0}.", Insertion));

            //int num1 = 8;
            //int num2 = 19;
            //BitMan.SwapNumbers(ref num1, ref num2);
            //var ww = BitMan.OppositeSignNumbers(9,-19);
            //var wv = BitMan.OppositeSignNumbers(8, 6);

            //int new_original_num = 12;

            //int result = BitMan.UpdateBit(new_original_num, 4, true);
            //Console.WriteLine(result);

            //int original_num = 8;
            //Console.WriteLine("Original number is " + original_num);

            //int num = BitMan.SetBit(original_num, 4);
            //Console.WriteLine("New number is " + num);

            //bool it = BitMan.GetBit(num, 4);
            //Console.WriteLine("Bit value is " + it);

            //num = BitMan.ClearBit(num, 4);
            //Console.WriteLine("New number is " + num);

            //it = BitMan.GetBit(num, 4);
            //Console.WriteLine("Bit value is " + it);

            //Console.ReadLine();

            //BitMan.IsUnique("luis");
            //Console.ReadLine();




            //int[,] exp = { { 0, 1, 1, 0, 1 }, { 0, 1, 0, 1, 0 }, { 0, 0, 0, 0, 1 }, { 0, 1, 0, 0, 0 } };
            //int val = Zombies.MinDays(exp);


            //int n1 = 2;

            //List<List<int>> items = new List<List<int>>();
            //items.Add(new List<int>(new int[3] { 1, 0, 5 }));
            //items.Add(new List<int>(new int[3] { 1, 1, 7 }));
            //items.Add(new List<int>(new int[3] { 1, 0, 3 }));
            //items.Add(new List<int>(new int[3] { 2, 1, 0 }));
            //items.Add(new List<int>(new int[3] { 2, 1, 1 }));

            //ArrayExercises.dynamicArray(n1, items);
            //Console.ReadLine();




            ////int[] array_x = { 1, 2, 3, 4, 5, 6, 7 };
            ////ArrayExercises.RotateArray(array_x, 3);
            //int[] array_a = { 1,1,1 };
            //int[] array_b = { 1, 2, 3, 4 };
            //int[] array_c = { 4, 1, 2, 3 };
            //int[] array_d = { 1, 2, 4, 3 };
            //int[] array_e = { 1, 2, 5, 4, 5 };
            //int[] array_f = { 1, 2, 5, 5, 6 };
            //int[] array_g = { 4, 2, 1 };

            //// 1,2,3,4 <= true
            //// 4,1,2,3 <= true
            //// 1,2,4,3 <= true
            //// 1,2,5,4,5 <= true
            //// 1,2,5,5,6 <= true;


            //var a1 = ArrayExercises.CheckPossibility(array_a);
            //var b1 = ArrayExercises.CheckPossibility(array_b);
            //var c1 = ArrayExercises.CheckPossibility(array_c);
            //var d1 = ArrayExercises.CheckPossibility(array_d);
            //var e1 = ArrayExercises.CheckPossibility(array_e);
            //var f1 = ArrayExercises.CheckPossibility(array_f);
            //var g1 = ArrayExercises.CheckPossibility(array_g);

            //Console.ReadLine();

            //int[] x_f = { 0, 2, 0, 3, 0, 5, 6, 0, 0 };
            //int[] y_f = { 1, 8, 9, 10, 15 };

            //MergeArraysExercise.Rearrange(x_f, y_f);
            //Console.ReadLine();

            //Exercise01 exercise01 = new Exercise01();
            //exercise01.PrintMatrix();
            //Console.ReadLine();


            //int runs = 0;

            //LifeSimulation sim = new LifeSimulation(Heigth, Width);

            //while (runs++ < MaxRuns)
            //{
            //    sim.DrawAndGrow();

            //    // Give the user a chance to view the game in a more reasonable speed.
            //    System.Threading.Thread.Sleep(100);
            //}
            //Console.ReadLine();

            //int[] first_array = { 1, 4, 7, 8, 10 };
            //int[] second_array = { 2, 3, 9 };

            //OneDimensionalArray.MergeTwoArrays(first_array, second_array);
            //Console.WriteLine("First Array: ");
            //foreach (int i in first_array)
            //{
            //    Console.Write(i + ",");
            //}
            //Console.WriteLine("\nSecond Array: ");
            //foreach (int i in second_array)
            //{
            //    Console.Write(i + ",");
            //}
            //Console.ReadLine();


            //int[] BinArray = { 0, 0, 1, 0, 1, 0, 0 };
            //int[] Consecutives = { 2, 0, 2, 1, 4, 3, 1, 0 };
            //int[] MaxLength = { 5,6,-5,5,3,5,3,-2,0 };
            //int[] ThreeWay = { 0, 1, 2, 2, 1, 0, 0, 2, 0, 1, 1, 0 };

            //OneDimensionalArray.ThreeWayPartition(ThreeWay, ThreeWay.Length - 1);
            //foreach (int i in ThreeWay)
            //{
            //    Console.Write(i + ",");
            //}
            //Console.ReadLine();

            //OneDimensionalArray.MaxLengthSubArrayBinary(BinArray);
            //Console.ReadLine();

            //OneDimensionalArray.MaxLengthSubArray(MaxLength, 8);
            //Console.ReadLine();

            //OneDimensionalArray.FindMaxSubArray(Consecutives);

            //Console.ReadLine();



            //var x12 = CodeChef.EasyCodeChef.DecrementOrIncrement(5);
            //Console.WriteLine(x12);
            //var x22 = CodeChef.EasyCodeChef.DecrementOrIncrement(8);
            //Console.WriteLine(x22);
            //Console.ReadLine();

            //int[] duplicate_array = { 1,2,3,4,4 };
            //OneDimensionalArray.FindDuplicateItem(duplicate_array);
            //Console.ReadLine();

            //int[] binary_array = { 1,0,1,0,1,0,0,1 };

            //OneDimensionalArray.SortBinaryArray(binary_array);
            //Console.ReadLine();

            //int R = 3;
            //int C = 6;
            //int[,] array = { {  1,  2,  3,  4,  5,  6 },
            //                 {  7,  8,  9, 10, 11, 12 },
            //                 { 13, 14, 15, 16, 17, 18 } };




            //MultiDimensionalArray.PrintSpiralOrder(R,C,array);
            //Console.ReadLine();

            //int[] arr8 = { 0,0,0,0,4,5,6,7 };
            //IEnumerable<int> ah = OneDimensionalArray.PlusOne(arr8.ToList());

            //foreach (int i in ah)
            //{
            //    Console.Write(i + " ");
            //}


            //Console.ReadLine();

            //int[] arr0 = { 8, 7, 2, 5, 3, 1 };
            //OneDimensionalArray.FindPairNLogN(arr0, 10);
            //int[] zarr = { 4, 2, -3, -1, 0, 4};
            ////Console.WriteLine(string.Format("Can you add zero? {0}.",DataStructures.Arrays.OneDimensionalArray.ZeroSumSubarray(zarr) ? "Yes" : "No"));
            //OneDimensionalArray.PrintAllSubarrays(zarr);
            //Console.ReadLine();

            //int[] arr1 = { 7,1,3,2,4,5,6 };
            //int[] arr2 = { 4,3,1,2 };
            //int[] arr3 = { 2, 3, 4, 1, 5 };
            //int[] arr4 = { 1,3,5,2,4,6,7 };


            //int x1 = HackerRank.ArrayExercises.MinimumSwaps(arr1);
            //int x2 = HackerRank.ArrayExercises.MinimumSwaps(arr2);
            //int x3 = HackerRank.ArrayExercises.MinimumSwaps(arr3);
            //int x4 = HackerRank.ArrayExercises.MinimumSwaps(arr4);


            //Console.WriteLine(x1);
            //Console.WriteLine(x2);
            //Console.WriteLine(x3);
            //Console.WriteLine(x4);
            //Console.ReadLine();
            ////HackerRank.ArrayExercises.MinimumBribes(arr);

            ////Graph grapho = new Graph();

            ////Vertex vertexLuis = new Vertex
            ////{
            ////    Name = "Luis"
            ////};
            ////Vertex vertexKitt = new Vertex
            ////{
            ////    Name = "Kitt"
            ////};
            ////Vertex vertexCarlos = new Vertex
            ////{
            ////    Name = "Carlos"
            ////};
            ////Vertex vertexJuan = new Vertex
            ////{
            ////    Name = "Juan"
            ////};
            ////Vertex vertexJohn = new Vertex
            ////{
            ////    Name = "John"
            ////};

            ////vertexLuis.Nodes.Add(vertexKitt);
            ////vertexLuis.Nodes.Add(vertexCarlos);
            ////vertexLuis.Nodes.Add(vertexJuan);

            ////vertexKitt.Nodes.Add(vertexLuis);
            ////vertexKitt.Nodes.Add(vertexCarlos);
            ////vertexKitt.Nodes.Add(vertexJuan);

            ////vertexCarlos.Nodes.Add(vertexKitt);
            ////vertexCarlos.Nodes.Add(vertexLuis);
            ////vertexCarlos.Nodes.Add(vertexJuan);

            ////vertexJuan.Nodes.Add(vertexLuis);
            ////vertexJuan.Nodes.Add(vertexCarlos);

            ////grapho.Vertices.Add(vertexJuan);
            ////grapho.Vertices.Add(vertexCarlos);
            ////grapho.Vertices.Add(vertexLuis);
            ////grapho.Vertices.Add(vertexKitt);

            //////grapho.DepthFirstSearch(vertexJuan, 1);
            //////grapho.DepthFirstSearchNR(vertexLuis);
            //////grapho.BreadthFirstSearchNR(vertexLuis);

            ////bool x1 = grapho.RouteBetweenNodes(vertexLuis, vertexJohn);
            //////bool x2 = grapho.RouteBetweenNodes(vertexCarlos, vertexJuan);

            ////Console.ReadLine();

            //Vertex a = new Vertex
            //{
            //    Name = "a"
            //};
            //Vertex b = new Vertex
            //{
            //    Name = "b"
            //};
            //Vertex c = new Vertex
            //{
            //    Name = "c"
            //};
            //Vertex d = new Vertex
            //{
            //    Name = "d"
            //};
            //Vertex e = new Vertex
            //{
            //    Name = "e"
            //};
            //Vertex f = new Vertex
            //{
            //    Name = "f"
            //};

            //a.Nodes.Add(d);
            ////d.Nodes.Add(a);
            //f.Nodes.Add(b);
            //b.Nodes.Add(d);
            //f.Nodes.Add(a);
            //d.Nodes.Add(c);


            //Graph n = new Graph();
            //n.Vertices.Add(a);
            //n.Vertices.Add(b);
            //n.Vertices.Add(c);
            //n.Vertices.Add(d);
            //n.Vertices.Add(e);
            //n.Vertices.Add(f);

            //try
            //{
            //    n.TopologicalSort(); 
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Console.ReadLine();


            ////int[] a = { 1, 5, 2, 6, 3, 7 };
            ////int[] b = { 5, 6, 7, 1, 2, 3 };

            ////List<int[]> x = Exercise1.FindSubstringLocation("BCXXBXXCXDXBCD", "BCD");
            ////PrintResults(x);
            ////Console.WriteLine("\n");
            ////List<int[]> y = Exercise1.FindSubstringLocation("BCXXBXCXBCBC", "BCBC");
            ////PrintResults(y);

            ////int[] s = { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            ////int FinalResult = WarmUp.SockMerchant(9, s);
            ////Console.WriteLine(FinalResult);

            ////string v = "UDDDUDUU";

            ////int FinalOutput = WarmUp.CountingValleys(8, v);


            ////int[] arr = { 88, 23, 65, 2, 89, 7, 3, 1, 90, 4 };

            ////Console.WriteLine("\n");
            ////Console.WriteLine("Before MergeSort:");
            ////foreach (int i in arr)
            ////{
            ////    Console.Write(i + ",");
            ////}

            ////MergeSortAlgorithm.MergeSort(arr, 0, arr.Length - 1);

            ////Console.WriteLine("\n");
            ////Console.WriteLine("After MergeSort:");
            ////foreach (int i in arr)
            ////{
            ////    Console.Write(i + ",");
            ////}
            ////Console.WriteLine("\n");

            ////int[] c = { 0,0,1,0,0,1,0 };


            ////int val = WarmUp.JumpingOnClouds(c);
            ////Console.WriteLine(val);
            ////Console.WriteLine("\n");

            //////Console.WriteLine("Before QuickSort");
            //////Console.WriteLine("\n");
            //////foreach (int i in arr)
            //////{
            //////    Console.Write(i + ",");
            //////}

            //////QuickSortAlgorithm.QuickSort(arr, 0, arr.Length - 1);

            //////Console.WriteLine("\n");
            //////Console.WriteLine("After QuickSort");
            //////foreach (int i in arr)
            //////{
            //////    Console.Write(i + ",");
            //////}

            //////MultidimensionalArrays mda = new MultidimensionalArrays();
            /////* SolutionOne NewSolution = new SolutionOne();


            //// int[][] edges = { new int[] { 1, 0 }, 
            ////                   new int[] { 1, 2 }, 
            ////                   new int[] { 1, 3 } };

            //// NewSolution.FindMinHeightTrees(4,edges);
            //// */

            //////FindMissingElement x = new FindMissingElement();

            //////int[] a1 = { 4, 12, 9, 5, 6 };
            //////int[] a2 = { 4, 9, 12, 6 };

            //////int y = x.FindMissingElementXor(a1, a2);
            //////int z = x.FindCommonElementAnd(a1, a2);

            //////Console.WriteLine(string.Format("'{0}' was the missing element in the array.", y));
            //////Console.WriteLine(string.Format("'{0}' were the common elements in the array", z));

            //////NewSolution.TwoSum(Nums, Target);



            /////*BinaryTree<int> BTree = new BinaryTree<int>();
            ////BTree.Insert(100);
            ////BTree.Insert(7);
            ////BTree.Insert(10);
            ////BTree.Insert(101);
            ////BTree.Insert(105);
            ////var Root = BTree.Find(100);
            ////BTree.InOrder(Root);

            ////Console.ReadLine();


            ////SinglyLinkedList<int> SinglyLinkedListObj1 = new SinglyLinkedList<int>();
            ////SinglyLinkedListObj1.AddToBeginning(1);
            ////SinglyLinkedListObj1.AddToBeginning(2);
            ////SinglyLinkedListObj1.AddToBeginning(3);

            ////SinglyLinkedListObj1.DisplaySinglyLinkedList();

            ////SinglyLinkedList<int> SinglyLinkedListObj2 = new SinglyLinkedList<int>();
            ////SinglyLinkedListObj2.AddToEnd(1);
            ////SinglyLinkedListObj2.AddToEnd(2);
            ////SinglyLinkedListObj2.AddToEnd(3);
            ////SinglyLinkedListObj2.AddToEnd(2);
            ////SinglyLinkedListObj2.AddToEnd(2);
            ////SinglyLinkedListObj2.AddToEnd(1);

            ////SinglyLinkedListObj2.DisplaySinglyLinkedList();

            //////SinglyLinkedListObj2.DeleteNode(2);
            //////SinglyLinkedListObj2.DeleteFromBeginning();
            ////SinglyLinkedListObj2.DeleteFromEnd();

            ////SinglyLinkedListObj2.DisplaySinglyLinkedList();
            ////SinglyLinkedListObj2.FindItem(97);
            ////SinglyLinkedListObj2.FindItem(1);
            ////SinglyLinkedListObj2.DeleteFromBeginning();
            ////SinglyLinkedListObj2.FindItem(1);

            ////Console.WriteLine("----------------------");
            ////Console.WriteLine("--- STACK ---");

            ////LLStack<int> SimpleStack = new LLStack<int>();
            ////SimpleStack.Push(20);
            ////SimpleStack.Push(40);

            ////SimpleStack.DisplayStack();

            ////SimpleStack.Push(60);
            ////SimpleStack.Push(80);

            ////SimpleStack.DisplayStack();
            ////SimpleStack.Pop();
            ////SimpleStack.Pop();
            ////SimpleStack.DisplayStack();

            ////Console.WriteLine("----------------------");
            ////Console.WriteLine("--- QUEUE ---");

            ////LLQueue<int> SimpleQueue = new LLQueue<int>();
            ////SimpleQueue.Enqueue(20);
            ////SimpleQueue.Enqueue(40);

            ////SimpleQueue.DisplayQueue();

            ////SimpleQueue.Enqueue(60);
            ////SimpleQueue.Enqueue(80);

            ////SimpleQueue.DisplayQueue();

            ////SimpleQueue.Dequeue();
            ////SimpleQueue.Dequeue();

            ////SimpleQueue.DisplayQueue();

            ////Console.WriteLine("----------------------");
            ////Console.ReadLine();*/
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
