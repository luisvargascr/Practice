using System;
using DataStructures;
using Algorithms;
using DataStructures.LinkedList;
using DataStructures.Stack;
using DataStructures.Queue;

namespace Main
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // MergeSort mergeSort = new MergeSort();
            // MultidimensionalArrays mda = new MultidimensionalArrays();


            SinglyLinkedList<int> SinglyLinkedListObj1 = new SinglyLinkedList<int>();
            SinglyLinkedListObj1.AddToBeginning(1);
            SinglyLinkedListObj1.AddToBeginning(2);
            SinglyLinkedListObj1.AddToBeginning(3);

            SinglyLinkedListObj1.TraverseList();

            SinglyLinkedList<int> SinglyLinkedListObj2 = new SinglyLinkedList<int>();
            SinglyLinkedListObj2.AddToEnd(1);
            SinglyLinkedListObj2.AddToEnd(2);
            SinglyLinkedListObj2.AddToEnd(3);
            SinglyLinkedListObj2.AddToEnd(2);
            SinglyLinkedListObj2.AddToEnd(2);
            SinglyLinkedListObj2.AddToEnd(1);

            SinglyLinkedListObj2.TraverseList();

            //SinglyLinkedListObj2.DeleteNode(2);
            //SinglyLinkedListObj2.DeleteFromBeginning();
            SinglyLinkedListObj2.DeleteFromEnd();
            
            SinglyLinkedListObj2.TraverseList();
            SinglyLinkedListObj2.FindItem(97);
            SinglyLinkedListObj2.FindItem(1);
            SinglyLinkedListObj2.DeleteFromBeginning();
            SinglyLinkedListObj2.FindItem(1);

            Console.WriteLine("----------------------");
            Console.WriteLine("--- STACK ---");

            LLStack<int> SimpleStack = new LLStack<int>();
            SimpleStack.Push(20);
            SimpleStack.Push(40);

            SimpleStack.DisplayStack();

            SimpleStack.Push(60);
            SimpleStack.Push(80);

            SimpleStack.DisplayStack();
            SimpleStack.Pop();
            SimpleStack.Pop();
            SimpleStack.DisplayStack();

            Console.WriteLine("----------------------");
            Console.WriteLine("--- QUEUE ---");

            LLQueue<int> SimpleQueue = new LLQueue<int>();
            SimpleQueue.Enqueue(20);
            SimpleQueue.Enqueue(40);

            SimpleQueue.DisplayQueue();

            SimpleQueue.Enqueue(60);
            SimpleQueue.Enqueue(80);

            SimpleQueue.DisplayQueue();

            SimpleQueue.Dequeue();
            SimpleQueue.Dequeue();

            SimpleQueue.DisplayQueue();



            Console.WriteLine("----------------------");

        }
    }
}
