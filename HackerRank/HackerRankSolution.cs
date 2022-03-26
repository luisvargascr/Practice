using System.Collections.Generic;

namespace HackerRank
{
    public class HackerRankSolution
    {
        public void Sort(List<int> A)
        {
            int start = 0;
            int end = A.Count - 1;
            QuickSort(A, start, end);
        }
        private void QuickSort(List<int> A, int start, int end)
        {
            if (start < end)
            {
                int pivot = Partition(A, start, end);
                QuickSort(A, start, pivot);
                QuickSort(A, pivot + 1, end);
            }
        }
        private int Partition(List<int> A, int start, int end)
        {
            int pivot = A[end - 1];

            while (true)
            {
                while (A[start] < pivot)
                {
                    start++;
                }
                while (A[end] > pivot)
                {
                    end--;
                }
                if (end <= start)
                {
                    return end;
                }
                int tmp = A[start];
                A[start] = A[end];
                A[end] = tmp;

                start++;
                end--;
            }
        }
        public int Solve(List<int> A, int B)
        {
            if (A.Count <= 1 && A[0] == B)
            {
                return 1;
            }
            else
            {
                this.Sort(A);
                int left = 0, right = A.Count - 1, middle = right / 2;

                while (left <= middle && right >= middle)
                {
                    int val = A[left] + B;
                    if (A[right] == val)
                    {
                        return 1;
                    }
                    left++;
                    right--;
                }
                return 0;
            }
        }
    }
}