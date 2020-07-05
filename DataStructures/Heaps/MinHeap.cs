using System;

namespace DataStructures.Heaps
{
    public class MinHeap
    {
        private int[] _heap;
        private int _maxSize;
        private int _currSize;

        public MinHeap(int maxSize)
        {
            _maxSize = maxSize;
            _currSize = 0;
            _heap = new int[_maxSize];
        }
        public bool IsEmpty()
        {
            return _currSize == 0;
        }
        public bool Insert(int val)
        {
            if (_currSize == _maxSize)
                return false;

            _heap[_currSize] = val;
            TrickleUp(_currSize++);

            return true;
        }
        public void TrickleUp(int pos)
        {
            int Parent = (pos - 1) / 2;
            int Bottom = _heap[pos];

            while(pos > 0 && _heap[Parent] > Bottom)
            {
                _heap[pos] = _heap[Parent];
                pos = Parent;
                Parent = (Parent - 1) / 2;
            }
            _heap[pos] = Bottom;
        }
        public int Remove()
        {
            int Root = _heap[0];
            _heap[0] = _heap[--_currSize];
            TrickleDown(0);
            return Root;
        }
        public void TrickleDown(int pos)
        {
            int SmallerChild;
            int Top = _heap[pos];

            while (pos < _currSize/2)
            {
                int LeftChild  = 2 * pos + 1;
                int RightChild = 2 * pos + 2;

                if (RightChild < _currSize && _heap[LeftChild] > _heap[RightChild])
                {
                    SmallerChild = RightChild;
                }
                else
                {
                    SmallerChild = LeftChild;
                }

                if (Top <= _heap[SmallerChild])
                    break;

                _heap[pos] = _heap[SmallerChild];
                pos = SmallerChild;
            }
            _heap[pos] = Top;
        }
        public void Print()
        {
            Console.WriteLine(string.Join(",", _heap));
        }
    }
}
