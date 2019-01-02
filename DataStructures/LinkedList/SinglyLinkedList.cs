using System;
namespace DataStructures.LinkedList
{
    public class SinglyLinkedList<T>
    {
        private Node<T> _head;
        private string _structureName;
        public SinglyLinkedList()
        {
            _structureName = "Singly Linked List";
        }
        public SinglyLinkedList(string structureName)
        {
            _structureName = structureName;
        }
        public bool FindItem (T item)
        {
            Node<T> tmp = _head;

            if (tmp == null)
            {
                Console.WriteLine(string.Format("{0} is empty. Item '{1}' was not found!",_structureName, item.ToString()));
                return false;
            }

            while (tmp != null)
            {
                if (tmp.data.Equals(item))
                {
                    Console.WriteLine(string.Format("Item '{0}' was found!", item.ToString()));
                    return true;
                }

                tmp = tmp.next;
            }
            Console.WriteLine(string.Format("Item '{0}' was not found!",item.ToString()));
            return false;
        }
        public T ReturnItem (T item)
        {
            Node<T> tmp = _head;

            if (tmp == null)
            {
                Console.WriteLine(string.Format("{0} is empty. Item '{1}' was not found!", _structureName, item.ToString()));
                return default(T);
            }
            while (tmp != null)
            {
                if (tmp.Equals(item))
                {
                    return tmp.data;
                }
            }
            return default(T);
        }
        public T ReturnFirstItem ()
        {
            Node<T> first = _head;

            if (first != null)
                return first.data;
            else
                return default(T);
        }
        public T ReturnLastItem()
        {
            Node<T> last = _head;

            if (last == null)
                return default(T);

            while (last.next != null)
            {
                last = last.next;
            }
            return last.data;
        }
        public void AddToBeginning(T item)
        {
            Node<T> tmp = new Node<T>
            {
                data = item
            };

            if (_head == null)
            {
                _head = tmp;
                _head.next = null;
            }
            else
            {
                tmp.next = _head;
                _head = tmp;
            }
        }
        public void AddToEnd (T item)
        {
            Node<T> tmp = new Node<T>
            {
                data = item
            };

            if (_head == null)
            {
                _head = tmp;
                _head.next = null;
            }
            else
            {
                Node<T> header = _head;
                while (header.next != null)
                {
                    header = header.next;
                }
                header.next = tmp;
            }
        }
        public void DeleteNode (T item)
        {
            Node<T> tmp = _head;
            Node<T> runner = null;

            while (tmp != null)
            {
                if (tmp.data.Equals(item))
                {
                    runner.next = tmp.next;
                    tmp = null;
                    tmp = runner;
                }
                else
                {
                    runner = tmp;
                }
                tmp = tmp.next;
            }
        }
        public void DeleteFromBeginning()
        {
            Node<T> tmp = _head;

            if (tmp == null)
                return;
                
            _head = tmp.next;
            tmp = null;
        }
        public void DeleteFromEnd()
        {
            Node<T> tmp = _head;

            if (tmp == null)
                return;

            Node<T> runner = null;

            while (tmp != null)
            {
                if (tmp.next != null)
                {
                    runner = tmp;
                    tmp = tmp.next;
                }
                else
                {
                    runner.next = null;
                    tmp = null;
                }
            }
        }
        public void DisplaySinglyLinkedList()
        {
            Node<T> tmp = _head;
            int cnt = 0;
            Console.WriteLine("Listing Contents:");

            if (tmp == null)
            {
                Console.WriteLine(string.Format("{0} is empty.",_structureName)); 
                return;
            }
           
            while (tmp != null)
            {
                cnt++;
                Console.WriteLine(string.Format("- Value {0} is: {1}.", cnt, tmp.data.ToString()));
                tmp = tmp.next;
            }
            Console.WriteLine("\n");
        }
    }
}
