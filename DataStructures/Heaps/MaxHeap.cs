﻿using System;

namespace DataStructures.Heaps
{
    public class MaxHeap
    {
        private int[] _heap;
        private int _maxSize;
        private int _currSize;

        public MaxHeap(int maxSize)
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
        public void TrickleUp2(int pos)
        {
            int Parent = (pos - 1) / 2;
            int Bottom = _heap[pos];

            while (pos > 0 && _heap[Parent] < Bottom)
            {
                _heap[pos] = _heap[Parent];
                pos = Parent;
                Parent = (Parent - 1) / 2;
            }
            _heap[pos] = Bottom;
        }
        public void TrickleUp(int pos)
        {
            int Parent = pos / 2;
            int Bottom = _heap[pos];

            while (pos > 1 && _heap[Parent] < Bottom)
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
            int LargerChild;
            int Top = _heap[pos];

            while (pos < _currSize / 2)
            {
                int LeftChild  = 2 * pos + 1;
                int RightChild = 2 * pos + 2;

                if (RightChild < _currSize && _heap[LeftChild] < _heap[RightChild])
                {
                    LargerChild = RightChild;
                }
                else
                {
                    LargerChild = LeftChild;
                }

                if (Top >= _heap[LargerChild])
                    break;

                _heap[pos] = _heap[LargerChild];
                pos = LargerChild;
            }
            _heap[pos] = Top;
        }
        public void Print()
        {
            string val = string.Empty;

            for (int i = 1; i < _maxSize; i++)
            {
                val += _heap[i] + ",";
            }
            val = val.Substring(0, val.Length - 1);
            Console.WriteLine(val);
            Console.WriteLine("End of MaxHeap");
        }
    }
}
