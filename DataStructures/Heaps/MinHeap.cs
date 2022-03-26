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
            _maxSize = maxSize + 1;
            _currSize = 1;
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
            int Parent = pos / 2;
            int Bottom = _heap[pos];

            while (pos > 1 && _heap[Parent] > Bottom)
            {
                int tmp = _heap[Parent];
                _heap[Parent] = _heap[pos];
                _heap[pos] = tmp;
                pos--;
                Parent = pos / 2;
            }
        }
        public int Remove()
        {
            int Root = _heap[1];
            _heap[1] = _heap[--_currSize];
            TrickleDown(1);
            return Root;
        }
        public void TrickleDown(int pos)
        {
            
            int Top = _heap[pos];

            int LeftChild = 2 * pos;
            int RightChild = 2 * pos + 1;
            int tmp = 0;

            while (pos > 0)
            { 
                if (Top > _heap[LeftChild])
                {
                    tmp = _heap[pos];
                    _heap[pos] = _heap[LeftChild];
                    _heap[LeftChild] = tmp;

                }else if (Top > _heap[RightChild])
                {
                    tmp = _heap[pos];
                    _heap[pos] = _heap[RightChild];
                    _heap[RightChild] = tmp;

                }
                Top = pos--;
                LeftChild = 2 * pos;
                RightChild = 2 * pos + 1;
            }
        }
        public void Print()
        {
            string val = string.Empty;

            for (int i = 1; i < _currSize; i++)
            {
                val += _heap[i] + ",";
            }
            val = val.Substring(0, val.Length - 1);
            Console.WriteLine(val);
            Console.WriteLine("End of MinHeap");
        }
    }
}
