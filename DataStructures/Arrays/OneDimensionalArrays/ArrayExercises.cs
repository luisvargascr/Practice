using System;
using System.Collections.Generic;

namespace DataStructures.Arrays.OneDimensionalArrays
{
    public static partial class ArrayExercises
    {
        public static IList<int> PancakeSort(int[] array)
        {
            List<int> rev = new List<int>();

            for (int i = array.Length; i > 1; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (array[j] == i)
                    {
                        rev.Add(j + 1);
                        Reverse(array, j + 1);
                        rev.Add(i);
                        Reverse(array, i);
                    }
                }
            }
            return rev;
        }
        private static void Reverse(int[] array, int end)
        {
            for (int i = 0; i < end / 2; i++)
            {
                int tmp = array[i];
                array[i] = array[end - 1 - i];
                array[end - 1 - i] = tmp;
            }
        }

        public static int CountSubstrings(string s)
        {
            int counter = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int offset = 1;
                while (i - offset >= 0 &&
                        i + offset < s.Length &&
                        s[i - offset] == s[i - 1] &&
                        s[i + offset] == s[i - 1])
                {

                    counter++;
                    offset++;
                }
                int repeats = 0;
                while (i + 1 < s.Length && s[i] == s[i + 1])
                {
                    repeats++;
                    i++;
                }
                counter += repeats * (repeats + 1) / 2;
            }
            return counter + s.Length;
        }
        public static void RotateArray(int[] nums, int k)
        {
            for (int i = nums.Length - 1; i >= k; i--)
            {
                int tmp = nums[nums.Length - 1];

                for (int j = nums.Length - 2; j >= 0; j--)
                {
                    nums[j + 1] = nums[j];
                }
                nums[0] = tmp;
            }
        }
        public static bool CheckPossibility(int[] nums)
        {

            int problem_index = -1;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    if (problem_index != -1)
                        return false;

                    problem_index = i;
                }
            }
            // 1,2,3,4 <= true
            // 4,1,2,3 <= true
            // 1,2,4,3 <= true
            // 1,2,5,4,5 <= true
            // 1,2,5,5,6 <= true;
            if (problem_index == -1)
                return true;

            if (problem_index == 0)
                return true;

            if (problem_index == nums.Length - 2)
                return true;

            if (nums[problem_index - 1] <= nums[problem_index + 1])
                return true;

            if (nums[problem_index] <= nums[problem_index + 2])
                return true;

            return false;
        }
        /*
            * Complete the 'dynamicArray' function below.
            *
            * The function is expected to return an INTEGER_ARRAY.
            * The function accepts following parameters:
            *  1. INTEGER n
            *  2. 2D_INTEGER_ARRAY queries
            */
        public static void ExecuteRuleOne(int n, ref int[][] seqList, int x, int y, ref int lastAnswer)
        {
            if (seqList[(x ^ lastAnswer) % n] == null)
            {
                seqList[(x ^ lastAnswer) % n] = new int[1] { y };
            }
            else
            {
                List<int> tmp = new List<int>(seqList[(x ^ lastAnswer) % n])
                {
                    y
                };
                seqList[(x ^ lastAnswer) % n] = tmp.ToArray();
            }
        }
        public static void ExecuteRuleTwo(int n, ref int[][] seqList, int x, int y, ref int lastAnswer)
        {
            if (seqList[(x ^ lastAnswer) % n] != null)
            {
                List<int> list = new List<int>(seqList[(x ^ lastAnswer) % n]);
                List<int> tmp = list;
                int find_val = seqList[(x ^ lastAnswer) % n][y % (tmp.Count)];
                lastAnswer = find_val;
            }
        }
        public static List<int> DynamicArray(int n, List<List<int>> queries)
        {
            int[][] seqList = new int[n][];
            var response = new List<int>();
            var lastAnswer = 0;

            for (int i = 0; i < queries.Count; i++)
            {
                int RuleNum = queries[i][0];
                int x_val = queries[i][1];
                int y_val = queries[i][2];

                switch (RuleNum)
                {
                    case 1:
                        ExecuteRuleOne(n, ref seqList, x_val, y_val, ref lastAnswer);
                        break;
                    case 2:
                        ExecuteRuleTwo(n, ref seqList, x_val, y_val, ref lastAnswer);
                        response.Add(lastAnswer);
                        Console.WriteLine(lastAnswer);
                        break;
                    default:
                        break;
                }
            }
            return response;
        }
    }
    
}
