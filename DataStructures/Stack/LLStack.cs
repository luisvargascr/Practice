using System;
using DataStructures.LinkedList;

namespace DataStructures.Stack
{
    public class LLStack <T>
    {
        private SinglyLinkedList<T> _internalList;

        public LLStack()
        {
            _internalList = new SinglyLinkedList<T>("Stack");
        }
        public void Push (T item)
        {
            // Add to the beginning.
            _internalList.AddToBeginning(item);
        }
        public T Pop ()
        {
            // Remove from the beginning.
            var value = _internalList.ReturnFirstItem();

            if (!value.Equals(default(T)))
                _internalList.DeleteFromBeginning();

            return value;
        }
        public T Peek()
        {
            return _internalList.ReturnFirstItem();
        }
        public void DisplayStack()
        {
            _internalList.TraverseList();
        }
    }
}
