using System;
namespace DataStructures.Tree.RBT
{
    public class Node<T> where T : IComparable
    {
        private T _item;
        private Node<T> _left, _right, _parent;
        private bool _red = true;

        public Node(T item, Node<T> parent)
        {
            this._item = item;
            this._parent = parent;
            this._left = _right = null;
        }
        public Node<T> Left
        {
            get
            {
                return _left;
            }
            set
            {
                _left = value;
            }
        }
        public Node<T> Right
        {
            get
            {
                return _right;
            }
            set
            {
                _right = value;
            }
        }
        public Node<T> Parent
        {
            get
            {
                return _parent;
            }
            set
            {
                _parent = value;
            }
        }
        public T Item
        {
            get
            {
                return _item;
            }
            set
            {
                _item = value;
            }
        }
        public bool Red
        {
            get
            {
                return _red;
            }
            set
            {
                _red = value;
            }
        }
    }
}