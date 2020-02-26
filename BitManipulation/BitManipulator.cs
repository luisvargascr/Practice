using System;
using System.Collections.Generic;

namespace BitManipulation
{
    public class BitManipulator
    {
        private int[] GetIntArray(long num)
        {
            List<int> listOfInts = new List<int>();
            while (num > 0)
            {
                var x = Convert.ToInt32(num % 10);
                listOfInts.Add(x);
                num = num / 10;
            }
            listOfInts.Reverse();
            return listOfInts.ToArray();
        }
        public int GetDecimalValue(long item)
        {
            int[] nums = GetIntArray(item);
            int res = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                res <<= 1;
                res |= nums[i];
            }
            return res;
        }
        public bool GetBit(int number, int position)
        {
            return ((number & (1 << position)) != 0);
        }
        public int SetBit (int number, int position)
        {
            return number | (1 << position);
        }
        public int ToggleBit (int number, int position)
        {
            return number ^ (1 << position);
        }
        public int ClearBit(int number, int position)
        {
            int mask = ~(1 << position);
            
            return number & mask;
        }
        public int UpdateBit (int number, int position, bool SetOrUnset)
        {
            int value = SetOrUnset ? 1 : 0;
            int mask = ~(1 << position);
            return (number & mask) | (value << position);
        }
        public void SwapNumbers (ref int num1, ref int num2)
        {
            if (num1 != num2)
            {
                num1 = num1 ^ num2;
                num2 = num1 ^ num2;
                num1 = num1 ^ num2;
            }
        }
        public bool OppositeSignNumbers(int num1, int num2)
        {
            Console.WriteLine(string.Format("Number 1     = {0}", Convert.ToString(num1, 2)));
            Console.WriteLine(string.Format("Number 2     = {0}", Convert.ToString(num2, 2)));
            int NewNumber = (num1 ^ num2);
            Console.WriteLine(string.Format("Number XORed = {0}", Convert.ToString(NewNumber, 2)));
            Console.WriteLine(string.Format("New Number   = {0}", NewNumber));
            Console.WriteLine("\n");
            return (num1 ^ num2) < 0;
        }
        public bool IsUnique (string str)
        {
            int checker = 0;
            for (int i = 0; i < str.Length; i++)
            {
                int val = str[i] - 'a';
                string binary = Convert.ToString(val, 2);
                Console.WriteLine(string.Format("Difference between current letter '{0}' minus 'a' = '{1}'. In binary = '{2}'.", str[i], val, binary));

                int mask = (1 << val); // makes mask
                binary = Convert.ToString(mask, 2);
                Console.WriteLine(string.Format("Mask = 1 << {0} = '{1}'.", val, binary));

                int diff = (checker & (1 << val)); // Checks bit
                binary = Convert.ToString(diff, 2);
                Console.WriteLine(string.Format("Diff between checker = '{0}' and Mask = '{1}' is = '{2}'.", Convert.ToString(checker,2), Convert.ToString(mask,2), diff));

                if (diff > 0)
                {
                    Console.WriteLine("String has repeated characters");
                    return false;
                }
                checker |= (1 << val); // Sets bit
                binary = Convert.ToString(checker, 2);
                Console.WriteLine(string.Format("Checker = {0}.", binary));
                Console.WriteLine("\n");
            }
            Console.WriteLine("String has unique characters");
            return true;
        }
        public int MissingNumber(IList<int> nums)
        {
            int missing = 0;

            for (int i = 0; i < nums.Count; ++i)
            {
                missing ^= i;
                missing ^= nums[i];
            }
            return missing ^= nums.Count;
        }
        public int BitInsertion(int num1, int num2, int i, int j)
        {
            int N = num1;
            int M = num2;

            Console.WriteLine(string.Format("Num 1 = '{0}'.", Convert.ToString(num1, 2)));
            Console.WriteLine(string.Format("Num 2 = '{0}'.", Convert.ToString(num2, 2)));
            Console.WriteLine(string.Format("i = '{0}'.", i)); // 2
            Console.WriteLine(string.Format("j = '{0}'.", j)); // 6

            int AllOnes = ~0; // 11111111111111111111111111111111
            Console.WriteLine(string.Format("All 1s = '{0}'.", Convert.ToString(AllOnes,2)));

            int left = AllOnes << (j + 1); // 111111111111111111111110000000 
            Console.WriteLine(string.Format("Left = '{0}'.", Convert.ToString(left, 2)));

            int v = (1 << i);
            Console.WriteLine(string.Format("v = '{0}'.", Convert.ToString(v, 2)));

            int right = ((1 << i) - 1); // 11
            Console.WriteLine(string.Format("Right = '{0}'.", Convert.ToString(right, 2)));

            int mask = left | right; // 111111111111111111111110000011
            Console.WriteLine(string.Format("Mask = '{0}'.", Convert.ToString(mask, 2)));

            int cleared = num1 & mask; // 10000000000
            Console.WriteLine(string.Format("Cleared = '{0}'.", Convert.ToString(cleared, 2)));

            int shifted = num2 << i; // 1001100
            Console.WriteLine(string.Format("Shifted = '{0}'.", Convert.ToString(shifted, 2)));

            int new_num = (cleared | shifted); // 10001001100

            Console.WriteLine(string.Format("Result = '{0}'.", Convert.ToString(new_num, 2)));

            return new_num;
        }
    }
}
