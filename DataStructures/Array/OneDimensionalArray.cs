using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Arrays
{
    public class OneDimensionalArray
    {
        #region Find Pair with given Sum
        /*
         Given an unsorted array of integers, find a pair with given sum in it.

            For example,

            Input:

            arr = [8, 7, 2, 5, 3, 1]
            sum = 10

            Output:

            Pair Found at index 0 and 2 (8 + 2)
            or
            Pair Found at index 1 and 4 (7 + 3)
             
             */
        public static void FindPair(int[] array, int sum)
        {
            var NumDic = new Dictionary<int, int>();

            for (int cnt = 0; cnt < array.Length; cnt++)
            {
                if (NumDic.ContainsKey(sum - array[cnt]))
                {
                    Console.WriteLine("Pair found at index " + NumDic[sum - array[cnt]] + " and " + cnt + string.Format(" ({0}+{1})", array[NumDic[sum - array[cnt]]], array[cnt]));
                }
                else
                {

                    NumDic.Add(array[cnt], cnt);
                }
            }
        }
        public static void FindPairNLogN(int[] arr, int sum)
        {
            Array.Sort(arr);
            int low = 0;
            int high = arr.Length - 1;

            while (low < high)
            {
                if (arr[low] + arr[high] == sum)
                {
                    Console.WriteLine("Pair found at index " + low + " and " + high + string.Format(" ({0}+{1})", arr[low], arr[high]));
                }
                if (arr[low] + arr[high] < sum)
                {
                    low++;
                }
                else
                {
                    high--;
                }
            }
        }
        #endregion
        #region Check Subarray with 0 sum exists or not
        /*
          Given an array of integers, check if array contains a sub-array having 0 sum.

          For example,

          Input: {3, 4, -7, 3, 1, 3, 1, -4, -2, -2}
          Output: true

        */
        public static bool ZeroSumSubarray(int[] array)
        {
            var set = new HashSet<int>
            {
                0
            };

            int sum = 0;

            for (int cnt = 0; cnt < array.Length; cnt++)
            {
                sum += array[cnt];

                if (set.Contains(sum))
                {
                    return true;
                }
                set.Add(sum);
            }
            return false;
        }
        #endregion
        #region Find Sub Array with 0 Sum

        /* 
            Given an array of integers, print all sub-arrays with 0 sum.

            For example:

            Input: { 3,4,-7,3,1,-4,-2,-2 }

            Sub-Arrays with 0 Sum are

            { -3, -1, 0, 4 }
            { 0 }

        */
        public static void PrintAllSubarrays(int[] array)
        {
            var Subarray = new Dictionary<int, List<int>>();
            int sum = 0;

            for (int cnt = 0; cnt < array.Length; cnt++)
            {
                sum += array[cnt];

                if (Subarray.ContainsKey(sum))
                {
                    List<int> list = Subarray[sum];

                    foreach (int value in list)
                    {
                        Console.WriteLine("Subarray [" + (value + 1) + "..." + cnt + "]");
                    }
                }
                if (Subarray.ContainsKey(sum))
                {
                    Subarray[sum].Add(cnt);
                }
                else
                {
                    var newList = new List<int>
                    {
                        cnt
                    };
                    Subarray.Add(sum, newList);
                }
            }
        }
        #endregion
        public static List<int> PlusOne(List<int> A)
        {
            List<int> result = new List<int>();
            int carry = 1;
            for (int reverseIndex = A.Count - 1; reverseIndex >= 0; reverseIndex--)
            {
                int sum = A[reverseIndex] + carry;
                carry = sum / 10;
                result.Insert(0, sum % 10);
            }
            result.Insert(0, carry);
            result.RemoveRange(0, result.FindIndex(n => n != 0));
            return result;
        }
    }
}
