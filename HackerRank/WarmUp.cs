﻿using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    public static class WarmUp
    {
        #region SockMerchant Problem
        /*
         *  John works at a clothing store. He has a large pile of socks that he must pair by color for sale. Given an array of integers representing the color of each sock, determine how many pairs of socks with matching colors there are.

            For example, there are  socks with colors . There is one pair of color  and one of color . There are three odd socks left, one of each color. The number of pairs is .

            Function Description

            Complete the sockMerchant function in the editor below. It must return an integer representing the number of matching pairs of socks that are available.

            sockMerchant has the following parameter(s):

            n: the number of socks in the pile
            ar: the colors of each sock
            Input Format

            The first line contains an integer , the number of socks represented in . 
            The second line contains  space-separated integers describing the colors  of the socks in the pile.

            Constraints

             where 
            Output Format

            Return the total number of matching pairs of socks that John can sell.

            Sample Input

            9
            10 20 20 10 10 30 50 10 20
            Sample Output

            3   


            */

        public static int SockMerchant(int n, int[] arr)
        {
            var Pair = new Dictionary<int, int>();
         
            for (int cnt = 0; cnt < n; cnt++)
            {
                if (!Pair.ContainsKey(arr[cnt]))
                {
                    Pair.Add(arr[cnt], 1);
                }
                else
                {
                    Pair[arr[cnt]] += 1;
                }
            }
            int ActualPairs = 0;

            foreach (KeyValuePair<int,int> i in Pair)
            {
                if (i.Value >= 2)
                {
                    ActualPairs += i.Value / 2;
                }
            }
            return ActualPairs;
        }
        #endregion
        #region Avid Hiker
        /*

            Gary is an avid hiker. He tracks his hikes meticulously, paying close attention to small details like topography. During his last hike he took exactly  steps. For every step he took, he noted if it was an uphill, , or a downhill,  step. Gary's hikes start and end at sea level and each step up or down represents a  unit change in altitude. We define the following terms:

            A mountain is a sequence of consecutive steps above sea level, starting with a step up from sea level and ending with a step down to sea level.
            A valley is a sequence of consecutive steps below sea level, starting with a step down from sea level and ending with a step up to sea level.
            Given Gary's sequence of up and down steps during his last hike, find and print the number of valleys he walked through.

            For example, if Gary's path is , he first enters a valley  units deep. Then he climbs out an up onto a mountain  units high. Finally, he returns to sea level and ends his hike.

            Function Description

            Complete the countingValleys function in the editor below. It must return an integer that denotes the number of valleys Gary traversed.

            countingValleys has the following parameter(s):

            n: the number of steps Gary takes
            s: a string describing his path
            Input Format

            The first line contains an integer , the number of steps in Gary's hike. 
            The second line contains a single string , of  characters that describe his path.

            Constraints

            Output Format

            Print a single integer that denotes the number of valleys Gary walked through during his hike.

            Sample Input

            8
            UDDDUDUU
            Sample Output

            1
            Explanation

            If we represent _ as sea level, a step up as /, and a step down as \, Gary's hike can be drawn as:

            _/\      _
               \    /
                \/\/
            He enters and leaves one valley.           
            */
        public static int CountingValleys(int n, string s)
        {
            char[] input = s.ToCharArray();

            int ValleyCounter = 0;
            int OtherLevels = 0;

            for (int cnt = 0; cnt < input.Length; cnt++)
            {
                if (input[cnt].Equals('U'))
                {
                    if (++OtherLevels == 0)
                    {
                        ValleyCounter++;
                    }
                }
                else
                {
                    OtherLevels--;
                }
            }
            return ValleyCounter;
        }
        #endregion
        #region Jumping on clouds...
        /*
            Emma is playing a new mobile game that starts with consecutively numbered clouds. Some of the clouds are thunderheads and others are cumulus. She can jump on any cumulus cloud having a number that is equal to the number of the current cloud plus  or . She must avoid the thunderheads. Determine the minimum number of jumps it will take Emma to jump from her starting postion to the last cloud. It is always possible to win the game.

            For each game, Emma will get an array of clouds numbered  if they are safe or  if they must be avoided. For example,  indexed from . The number on each cloud is its index in the list so she must avoid the clouds at indexes  and . She could follow the following two paths:  or . The first path takes jumps while the second takes .

            Function Description

            Complete the jumpingOnClouds function in the editor below. It should return the minimum number of jumps required, as an integer.

            jumpingOnClouds has the following parameter(s):

            c: an array of binary integers
            Input Format

            The first line contains an integer , the total number of clouds. The second line contains  space-separated binary integers describing clouds  where .

            Constraints

            Output Format

            Print the minimum number of jumps needed to win the game.

            Sample Input 0

            7
            0 0 1 0 0 1 0
            Sample Output 0

            4
         */
        public static int JumpingOnClouds(int[] c)
        {
            HashSet<int> ValidCloudIndexes = new HashSet<int>();
            int ValidMoves = 0;

            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 0)
                {
                    ValidCloudIndexes.Add(i);
                }
            }
            int cnt = 0;

            while (cnt < c.Length)
            {
                if (ValidCloudIndexes.Contains(cnt + 2))
                {
                    ValidMoves++;
                    cnt = cnt + 2;
                }
                else
                {
                    if (ValidCloudIndexes.Contains(cnt + 1))
                    {
                        ValidMoves++;
                    }
                    cnt = cnt + 1;
                }
            }
            return ValidMoves;
        }
        #endregion
        #region Repeated String

        /*
            Lilah has a string, , of lowercase English letters that she repeated infinitely many times.

            Given an integer, , find and print the number of letter a's in the first  letters of Lilah's infinite string.

            For example, if the string  and , the substring we consider is , the first  characters of her infinite string. There are  occurrences of a in the substring.

            Function Description

            Complete the repeatedString function in the editor below. It should return an integer representing the number of occurrences of a in the prefix of length  in the infinitely repeating string.

            repeatedString has the following parameter(s):

            s: a string to repeat
            n: the number of characters to consider
            Input Format

            The first line contains a single string, . 
            The second line contains an integer, .

            Constraints

            For  of the test cases, .
            Output Format

            Print a single integer denoting the number of letter a's in the first  letters of the infinite string created by repeating  infinitely many times.

            Sample Input 0

            aba
            10
            Sample Output 0

            7
        */

        public static long RepeatedString(string s, long n)
        {

            char[] old_s = s.ToCharArray();
            long total_sub = n / old_s.Length;
            long rem_sub = n % old_s.Length;
            long a_total = 0;

            for (int cnt = 0; cnt < old_s.Length; cnt++)
            {
                if (old_s[cnt].Equals('a'))
                {
                    a_total++;
                }
            }
            var remainder = s.Substring(0, (int)rem_sub).Count(x => x.Equals('a'));

            a_total = (a_total * total_sub) + remainder;

            return a_total;
        }

        #endregion
    }
}
