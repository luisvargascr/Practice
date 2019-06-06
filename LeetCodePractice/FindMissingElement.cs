using System;

namespace LeetCodePractice
{
    public class FindMissingElement
    {
        public int FindMissingElementXor(int[] fullSet, int[] partialSet)
        {
            // int[] a1 = { 4, 12, 9, 5, 6 };
            // int[] a2 = { 4, 9, 12, 6 };


            int xor_sum = 0;
            foreach (int num in fullSet)
            {
                xor_sum ^= num;
            }
            foreach (int num in partialSet)
            {
                xor_sum ^= num;
            }

            return xor_sum;
        }
        public int FindCommonElementAnd(int[] fullSet, int[] partialSet)
        {
            int and_sum = 1;

            foreach (int num in fullSet)
            {
                and_sum &= num;
            }
            foreach (int num in partialSet)
            {
                and_sum &= num;
            }

            return and_sum;
        }
    }
}
