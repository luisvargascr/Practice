using System;
namespace DataStructures.Tree
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> LeftChild { get; set; }
        public Node<T> RightChild { get; set; }

        public Node()
        {
            Data = default(T);
            LeftChild = null;
            RightChild = null;
        }
    }
}
