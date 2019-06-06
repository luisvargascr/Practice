using System;
namespace DataStructures.Tree.RBT
{
    public class Node<T>
    {
        private T item;
        private Node<T> left, right, parent;
        private bool red = true;

        public Node(T item, Node<T> parent)
        {
            this.item = item;
            this.parent = parent;
            left = right = null;
        }
        public Node<T> Left
        {
            get
            {
                return left;
            }
            set
            {
                left = value;
            }
        }
        public Node<T> Right
        {
            get
            {
                return right;
            }
            set
            {
                right = value;
            }
        }
        public Node<T> Parent
        {
            get
            {
                return parent;
            }
            set
            {
                parent = value;
            }
        }
        public T Item
        {
            get
            {
                return item;
            }
            set
            {
                item = value;
            }
        }
        public bool Red
        {
            get
            {
                return red;
            }
            set
            {
                red = value;
            }
        }
    }
}
