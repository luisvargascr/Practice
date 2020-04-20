using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    public static class ManyExercises
    {
        public static string FreqAlphabets1(string s)
        {
            StringBuilder st = new StringBuilder();
            int num;

            for (int i = 0; i < s.Length; i++)
            {
                num = (s[i] - '0');

                if (i + 2 < s.Length && s[i + 2] == '#')
                {
                    num = num * 10 + (s[i + 1] - '0');
                    i += 2;
                }

                st.Append((char)('a' + num - 1));
            }

            return st.ToString();
        }
        public static string FreqAlphabets(string s)
        {
            StringBuilder UnencryptedString = new StringBuilder();

            if (s.Contains("#"))
            {
                var components = s.Split('#');
                
                for (int i = 0; i < components.Length; i++)
                {
                    if (components[i].Length > 2)
                    {
                        var sub = components[i].Substring(0, components[i].Length - 2);
                        for (int j = 0; j < sub.Length; j++)
                        {
                            var num = (char)(Char.GetNumericValue(components[i][j]) + 96);
                            UnencryptedString.Append(num);
                        }
                        var last = components[i].Substring(components[i].Length - 2);
                        var num2 = (char)(Convert.ToInt32(last) + 96);
                        UnencryptedString.Append(num2);
                    }
                    else if (i == components.Length - 1)
                    {
                        for (int j = 0; j < components[i].Length; j++)
                        {
                            var num = (char)(Char.GetNumericValue(components[i][j]) + 96);
                            UnencryptedString.Append(num);
                        }
                    }
                    else
                    {
                        var last = components[i].Substring(components[i].Length - 2);
                        var num2 = (char)(Convert.ToInt32(last) + 96);
                        UnencryptedString.Append(num2);
                    }
                }
            }
            else
            {
                for (int i = 0; i < s.Length; i++)
                {
                    var num = (char)(Char.GetNumericValue(s[i]) + 96);
                    UnencryptedString.Append(num);
                }
            }
            return UnencryptedString.ToString();
        }
        public static string ToLower(string str)
        {
            StringBuilder lowerCase = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 65 && str[i] <= 90)
                {
                    lowerCase.Append((char)(str[i] + 32));
                }
            }
            return lowerCase.ToString();
        }
        public static string ToUpper(string str)
        {
            StringBuilder upperCase = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 97 && str[i] <= 122)
                {
                    upperCase.Append((char)(str[i] - 32));
                }
            }
            return upperCase.ToString();
        }
        public static int Maximum69Number(int num)
        {
            var pow = (int) Math.Pow(10, (int)Math.Log10(num));
            var sum = 0;

            while (pow > 0)
            {
                if (num / pow == 6) return sum + 9 * pow + num % pow;
                sum += num / pow * pow;
                num %= pow;
                pow /= 10;
            }
            return sum;
        }
        public static int Reverse(int x)
        {
            if (x <= Int32.MinValue || x >= Int32.MaxValue) return 0;

            int RevInt = 0;
            int PrevInt = 0;
            bool PosInt = x >= 0 ? true : false;
            x = Math.Abs(x);

            while (x > 0)
            {
                int CurrInt = x % 10;
                RevInt = (RevInt * 10) + CurrInt;
                if ((RevInt - CurrInt) / 10 != PrevInt)
                    return 0;
                PrevInt = RevInt;
                x = x / 10;
            }

            return PosInt ? RevInt : RevInt * -1;
        }
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
