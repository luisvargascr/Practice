using System;

namespace DataStructures.BST.Tree
{
    public class BinaryTree<T> where T: IComparable
    {
        private Node<T> _root;

        public Node<T> Find(T item)
        {
            var current = _root;

            if (current == null)
                return null;
                
            while (!current.Data.Equals(item))
            {
                if (item.CompareTo(current.Data) < 0)
                {
                    current = current.LeftChild;
                }
                else
                {
                    current = current.RightChild;
                }
                if (current == null)
                    return null;
            }
            return current;
        }
        public void Insert(T item)
        {
            var newNode = new Node<T>
            {
                Data = item
            };

            if (_root == null)
            {
                _root = newNode;
            }
            else
            {
                var current = _root;
                Node<T> parent = null;

                while (true)
                {
                    parent = current;

                    if (current.Data.CompareTo(item) < 0)
                    {
                        current = current.LeftChild;
                        if (current == null)
                        {
                            parent.LeftChild = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.RightChild;
                        if (current == null)
                        {
                            parent.RightChild = newNode;
                            return;
                        }
                    }
                }

            }
        }
        public void PreOrder(Node<T> root)
        { 

            if (root != null)
            {
                Console.WriteLine(string.Format("{0}\n",root.Data));
                PreOrder(root.LeftChild);
                PreOrder(root.RightChild);
            }
        }
        public void InOrder(Node<T> root)
        {
            if (root != null)
            {
                InOrder(root.LeftChild);
                Console.WriteLine(string.Format("{0}\n", root.Data));
                InOrder(root.RightChild);
            }
        }
        public void PostOrder(Node<T> root)
        {
            if (root != null)
            {
                PostOrder(root.LeftChild);
                PostOrder(root.RightChild);
                Console.WriteLine(string.Format("{0}\n", root.Data));
            }
        }
        public void Delete (T item)
        {
        }
        public int SumEvenGrandparent(Node<int> root)
        {
            if (root == null)
                return 0;
            else if (root.Data % 2 == 0)
                return SumGrandChildren(root.LeftChild) + SumGrandChildren(root.RightChild) + SumEvenGrandparent(root.LeftChild) + SumEvenGrandparent(root.RightChild);
            else
                return SumEvenGrandparent(root.LeftChild) + SumEvenGrandparent(root.RightChild);

        }
        public int SumGrandChildren(Node<int> root)
        {
            if (root == null)
                return 0;

            int ans = 0;

            if (root.LeftChild != null)
                ans += root.LeftChild.Data;
            if (root.RightChild != null)
                ans += root.RightChild.Data;

            return ans;
        }

    }
}
