using System;
namespace DataStructures.Tree.RBT
{
    public class RBTree<T> where T: IComparable
    { 
        private int _numberElements;
        private Node<T> _root;
        private Node<T> _insertedNode;

        public RBTree()
        {
            _numberElements = 0;
            _root = null;
            _insertedNode = null;
        }
        private void LeftRotate(ref Node<T> node)
        {
            Node<T> nodeParent = node.Parent;
            Node<T> right = node.Right;
            Node<T> temp = right.Left;
            right.Left = node;
            node.Parent = right;
            node.Right = temp;

            if (temp != null)
            {
                temp.Parent = node;
            }
            if (right != null)
            {
                right.Parent = nodeParent;
            }
            node = right;
        }
        private void RightRotate(ref Node<T> node)
        {
            Node<T> nodeParent = node.Parent;
            Node<T> left = node.Right;
            Node<T> temp = left.Right;
            left.Left = node;
            node.Parent = left;
            node.Right = temp;

            if (temp != null)
            {
                temp.Parent = node;
            }
            if (left != null)
            {
                left.Parent = nodeParent;
            }
            node = left;
        }
        public void Add(T item)
        {
            _root = InsertNode(_root, item, null);
            _numberElements++;

            if (_numberElements > 2)
            {
                GetNodesAbove(_insertedNode, out Node<T> parent, out Node<T> grandParent, out Node<T> greatGrandParent);
                FixTreeAfterInsertion(_insertedNode, parent, grandParent, greatGrandParent);
            }
        }
        private Node<T> InsertNode(Node<T> node, T item, Node<T> parent)
        {
            IComparable nodeItem = node.Item as IComparable;
            IComparable origItem = item as IComparable;

            if (node == null)
            {
                Node<T> newNode = new Node<T>(item, parent);

                if (_numberElements > 0)
                {
                    newNode.Red = true;
                }
                else
                {
                    newNode.Red = false;
                }

                _insertedNode = newNode;

                return newNode;
            }
            else if (nodeItem.CompareTo(origItem) < 0)
            {
                node.Left = InsertNode(node.Left, item, node);
                return node;
            }
            else if (nodeItem.CompareTo(origItem) > 0)
            {
                node.Right = InsertNode(node.Right, item, node);
                return node;
            }
            else
            {
                throw new InvalidOperationException("Cannot add duplicate object.");
            }
        }
        private void GetNodesAbove(Node<T> curNode, out Node<T> parent, out Node<T> grandParent, out Node<T> greatGrandParent)
        {
            parent = null;
            grandParent = null;
            greatGrandParent = null;

            if (curNode != null)
            {
                parent = curNode.Parent;
            }
            if (parent != null)
            {
                grandParent = parent.Parent;
            }
            if (grandParent != null)
            {
                greatGrandParent = grandParent.Parent;
            }
        }
        private void FixTreeAfterInsertion(Node<T> child, Node<T> parent, Node<T> grandParent, Node<T> greatGrandParent)
        {
            if (grandParent != null)
            {
                Node<T> uncle = (grandParent.Right == parent) ? grandParent.Left : grandParent.Right;

                if (uncle != null && parent.Red && uncle.Red)
                {
                    uncle.Red = false;
                    parent.Red = false;
                    grandParent.Red = true;
                    Node<T> higher = null;
                    Node<T> stillHigher = null;

                    if (greatGrandParent != null)
                    {
                        higher = greatGrandParent.Parent;
                    }
                    if (higher != null)
                    {
                        stillHigher = higher.Parent;
                    }
                    FixTreeAfterInsertion(grandParent, greatGrandParent, higher, stillHigher);
                }
                else if (uncle == null || parent.Red && !uncle.Red)
                {
                    if (grandParent.Right == parent && parent.Right == child)
                    {
                        parent.Red = false;
                        grandParent.Red = true;

                        if (greatGrandParent != null)
                        {
                            if (greatGrandParent.Right == grandParent)
                            {
                                LeftRotate(ref grandParent);
                                greatGrandParent.Right = grandParent;
                            }
                            else
                            {
                                LeftRotate(ref grandParent);
                                greatGrandParent.Left = grandParent;
                            }
                        }
                        else
                        {
                            LeftRotate(ref _root);
                        }
                    }
                }
                else if (grandParent.Left == parent && parent.Left == child)
                {
                    parent.Red = false;
                    grandParent.Red = true;

                    if (greatGrandParent.Right != null)
                    {
                        if (greatGrandParent.Right == grandParent)
                        {

                            RightRotate(ref grandParent);
                            greatGrandParent.Right = grandParent;
                        }
                        else
                        {
                            RightRotate(ref grandParent);
                            greatGrandParent.Left = grandParent;
                        }
                    }
                    else
                    {
                        RightRotate(ref _root);
                    }
                }
                else if (grandParent.Right == parent && parent.Left == child)
                {
                    child.Red = false;
                    grandParent.Red = true;
                    RightRotate(ref parent);
                    grandParent.Right = parent;

                    if (greatGrandParent != null)
                    {
                        if (greatGrandParent.Right == grandParent)
                        {
                            LeftRotate(ref grandParent);
                            greatGrandParent.Right = grandParent;
                        }
                        else
                        {
                            LeftRotate(ref grandParent);
                            greatGrandParent.Left = grandParent;
                        }
                    }
                    else
                    {
                        LeftRotate(ref _root);
                    }
                }
                else if (grandParent.Left == parent && parent.Right == child)
                {
                    child.Red = false;
                    grandParent.Red = true;
                    LeftRotate(ref parent);
                    grandParent.Left = parent;
                    if (greatGrandParent != null)
                    {
                        if (greatGrandParent.Right == grandParent)
                        {
                            RightRotate(ref grandParent);
                            greatGrandParent.Right = grandParent;
                        }
                        else
                        {
                            RightRotate(ref grandParent);
                            greatGrandParent.Left = grandParent;
                        }
                    }
                    else
                    {
                        RightRotate(ref _root);
                    }
                }
            }
            if (_root.Red)
                _root.Red = false;
        }
    }
}
