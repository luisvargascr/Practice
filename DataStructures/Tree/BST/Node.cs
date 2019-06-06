using System;
namespace DataStructures.BST.Tree
{
    public class Node<T> where T: IComparable
    {
        public T Data { get; set; }
        public Node<T> LeftChild { get; set; }
        public Node<T> RightChild { get; set; }
    }
}
