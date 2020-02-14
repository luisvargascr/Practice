﻿using System.Collections.Generic;

namespace LeetCodePractice
{
    public static class Exercises
    {
        /*
            For some fixed N, an array A is beautiful if it is a permutation of the integers 1, 2, ..., N, such that:

            For every i < j, there is no k with i < k < j such that A[k] * 2 = A[i] + A[j].

            Given N, return any beautiful array A.  (It is guaranteed that one exists.)
        
            Example 1:

            Input: 4
            Output: [2,1,4,3]

            Example 2:

            Input: 5
            Output: [3,1,2,5,4]  
            
            1 <= N <= 1000
        */


        private static Dictionary<int, int[]> _memo;
        public static int[] BeautifulArray (int n)
        {
            _memo = new Dictionary<int, int[]>();
            return MagicFunction(n);
        }
        private static int[] MagicFunction(int n)
        {
            if (_memo.ContainsKey(n))
                return _memo[n];

            int[] nums = new int[n];
            if (n == 1)
                nums[0] = 1;
            else
            {
                int temp = 0;
                foreach (var x in MagicFunction((n + 1) / 2))
                    nums[temp++] = 2 * x - 1;
                foreach (var x in MagicFunction(n / 2))
                    nums[temp++] = 2 * x;
            }
            _memo.Add(n, nums);
            return nums;
        }
        public static int SingleNonDuplicate(int[] nums)
        {
            var lo = 0;
            var hi = nums.Length - 1;

            while (lo <= hi)
            {
                var mid = (lo + hi) / 2;
                var left = mid <= 0 || nums[mid - 1] != nums[mid];
                var right = mid >= nums.Length - 1 || nums[mid] != nums[mid + 1];
                if (left && right)
                {
                    return nums[mid];
                }
                if (mid % 2 == 0)
                {
                    if (nums[mid] == nums[mid + 1])
                    {
                        lo = mid + 1;
                    }
                    else
                    {
                        hi = mid - 1;
                    }
                }
                else
                {
                    if (nums[mid - 1] == nums[mid])
                    {
                        lo = mid + 1;
                    }
                    else
                    {
                        hi = mid - 1;
                    }
                }
            }
            return -1;
        }
    }
}
