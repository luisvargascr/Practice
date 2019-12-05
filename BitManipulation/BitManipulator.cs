using System;

namespace BitManipulation
{
    public class BitManipulator
    {
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
    }
}
