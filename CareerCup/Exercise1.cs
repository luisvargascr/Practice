using System;
using System.Collections;
using System.Collections.Generic;

namespace CareerCup
{
    public static class Exercise1
    {
        /*
         * CAREERCUP - Sample Exercise      
            Find the location of BCD in String S
            Given for example S - BCXXBXXCXDXBCD, then the result should be
            [[4,7,9],[11,12,13]]
            find BCBC in String S = BCXXBXCXBCBC
            the result should be [[0,1,4,6],[8,9,10,11]]
            */


        public static List<int[]> FindSubstringLocation(string input, string sub)
        {
            char[] chInput = input.ToCharArray();
            char[] chSub = sub.ToCharArray();

            int[] indexes = new int[chSub.Length];
            List<int[]> finalOutput = new List<int[]>();
            int j = 0;

            for (int i = 0; i < chInput.Length; i++)
            {
                if (j == chSub.Length - 1 && chInput[i].Equals(chSub[0]))
                {
                    j = 0;
                    indexes = new int[chSub.Length];
                }
                if (chSub[j].Equals(chInput[i]))
                {
                    indexes[j] = i;

                    if (j == chSub.Length - 1)
                    {
                        finalOutput.Add(indexes);
                        indexes = new int[chSub.Length];
                        j = 0;
                    }
                    else
                    {
                        j++;
                    }
                }
            }
            return finalOutput;
        }
    }
}
