using System;
using DataStructures.LinkedList;

namespace DataStructures.Queue
{
    public class LLQueue <T>
    {
        private SinglyLinkedList<T> _internalList;

        public LLQueue()
        {
            _internalList = new SinglyLinkedList<T>("Queue");
        }
        public void Enqueue(T item)
        {
            _internalList.AddToEnd(item);
        }
        public T Dequeue()
        {
            var value = _internalList.ReturnFirstItem();
            if (!value.Equals(default(T)))
                _internalList.DeleteFromBeginning();
            return value;
        }
        public T Peek()
        {
            return _internalList.ReturnFirstItem();
        }
        public void DisplayQueue()
        {
            _internalList.TraverseList();
        }
    }
}
