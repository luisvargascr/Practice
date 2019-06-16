using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    public static class ArrayExercises
    {
        #region 2D Array
        /*
            Given a  2D Array, :

            1 1 1 0 0 0
            0 1 0 0 0 0
            1 1 1 0 0 0
            0 0 0 0 0 0
            0 0 0 0 0 0
            0 0 0 0 0 0
            We define an hourglass in  to be a subset of values with indices falling in this pattern in 's graphical representation:

            a b c
              d
            e f g
            There are  hourglasses in , and an hourglass sum is the sum of an hourglass' values. Calculate the hourglass sum for every hourglass in , then print the maximum hourglass sum.

            For example, given the 2D array:

            -9 -9 -9  1 1 1 
             0 -9  0  4 3 2
            -9 -9 -9  1 2 3
             0  0  8  6 6 0
             0  0  0 -2 0 0
             0  0  1  2 4 0
            We calculate the following  hourglass values:

            -63, -34, -9, 12, 
            -10, 0, 28, 23, 
            -27, -11, -2, 10, 
            9, 17, 25, 18
            Our highest hourglass value is  from the hourglass:

            0 4 3
              1
            8 6 6
            Note: If you have already solved the Java domain's Java 2D Array challenge, you may wish to skip this challenge.

            Function Description

            Complete the function hourglassSum in the editor below. It should return an integer, the maximum hourglass sum in the array.

            hourglassSum has the following parameter(s):

            arr: an array of integers
            Input Format

            Each of the  lines of inputs  contains  space-separated integers .

            Constraints

            Output Format

            Print the largest (maximum) hourglass sum found in .

            Sample Input

            1 1 1 0 0 0
            0 1 0 0 0 0
            1 1 1 0 0 0
            0 0 2 4 4 0
            0 0 0 2 0 0
            0 0 1 2 4 0
            Sample Output

            19

        */

        public static int HourglassSum(int[][] arr)
        {
            int max = 0;
            for (int rows = 1; rows <= 4; ++rows)
            {
                for (int cols = 1; cols <= 4; ++cols)
                {
                    int temp = arr[rows - 1][cols - 1] +
                               arr[rows - 1][cols] +
                               arr[rows - 1][cols + 1] +
                               arr[rows][cols] +
                               arr[rows + 1][cols - 1] +
                               arr[rows + 1][cols] +
                               arr[rows + 1][cols + 1];
                               max = Math.Max(max, temp);
                }
            }
            return max;
        }
        #endregion
        #region New Year's Bribbing

        /*
            It's New Year's Day and everyone's in line for the Wonderland rollercoaster ride! There are a number of people queued up, and each person wears a sticker indicating their initial position in the queue. Initial positions increment by  from  at the front of the line to  at the back.

            Any person in the queue can bribe the person directly in front of them to swap positions. If two people swap positions, they still wear the same sticker denoting their original places in line. One person can bribe at most two others. For example, if and  bribes , the queue will look like this: .

            Fascinated by this chaotic queue, you decide you must know the minimum number of bribes that took place to get the queue into its current state!

            Function Description

            Complete the function minimumBribes in the editor below. It must print an integer representing the minimum number of bribes necessary, or Too chaotic if the line configuration is not possible.

            minimumBribes has the following parameter(s):

            q: an array of integers
            Input Format

            The first line contains an integer , the number of test cases.

            Each of the next  pairs of lines are as follows: 
            - The first line contains an integer , the number of people in the queue 
            - The second line has  space-separated integers describing the final state of the queue.

            Constraints

            Subtasks

            For  score 
            For  score 

            Output Format

            Print an integer denoting the minimum number of bribes needed to get the queue into its final state. Print Too chaotic if the state is invalid, i.e. it requires a person to have bribed more than  people.

            Sample Input

            2
            5
            2 1 5 3 4
            5
            2 5 1 3 4
            Sample Output

            3
            Too chaotic

         */

        public static void MinimumBribes(int[] arrList)
        {
            int bribe = 0;

            for (int i = arrList.Length - 1; i > -1; i--)
            {
                int element = i + 1;
                if (arrList[i] != element)
                {
                    if (arrList[i - 1] == element)
                    {
                        arrList[i - 1] = arrList[i];
                        arrList[i] = element;
                        bribe++;
                    }
                    else if (arrList[i - 2] == element)
                    {
                        arrList[i - 2] = arrList[i - 1];
                        arrList[i - 1] = arrList[i];
                        arrList[i] = element;
                        bribe += 2;
                    }
                    else
                    {
                        Console.WriteLine("Too chaotic");
                        bribe = 0;
                        break;
                    }
                }
            }
            if (bribe > 0)
                Console.WriteLine(bribe);
        }
        #endregion
    }
}
