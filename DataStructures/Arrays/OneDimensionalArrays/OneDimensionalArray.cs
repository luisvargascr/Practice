using System;
using System.Collections.Generic;

namespace DataStructures.Arrays.OneDimensionalArrays
{
    public static class OneDimensionalArray
    {
          /*
         
           There are n people whose IDs go from 0 to n - 1 and each person belongs exactly to one group.Given the array groupSizes of length n telling the group size each person belongs to, return the groups there are and the people's IDs each group includes.

            You can return any solution in any order and the same applies for IDs.Also, it is guaranteed that there exists at least one solution. 

            Example 1:

            Input: groupSizes = [3, 3, 3, 3, 3, 1, 3]
            Output: [[5], [0,1,2], [3,4,6]]
            Explanation: 
            Other possible solutions are[[2,1,6],[5],[0,4,3]] and[[5],[0,6,2],[4,3,1]].
            Example 2:

            Input: groupSizes = [2,1,3,3,3,2]
                    Output: [[1],[0,5],[2,3,4]]
 

            Constraints:

            groupSizes.length == n
            1 <= n <= 500
            1 <= groupSizes[i] <= n
        */

        public static IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            //Here we declare the list that will contain our result
            IList<IList<int>> groups = new List<IList<int>>();

            //We need a list where the id's will be stored, and the this list will be added to the 'groups'
            List<int>[] buildingGroups = new List<int>[groupSizes.Length + 1];

            //The algorithm works this way:
            //groupSizes = 3,3,3,3,3,1,3
            //It means that the person ID 0 belongs to a group containig a total of 3 people,
            //So he can form a group with id 1 and 2 cuz they also belong to a group of 3 people.
            //We add id 0, 1 and 2 to the list with ID 3 (the group size).
            //Everytime we add a person to a group, we check if the group is complete.
            //So, when we add 2, the group is complete because the list with ID 3 already
            //contains 3 elements, so we add this group of 3 elements to the 'groups' lists, and make
            //it empty so, if there will be other people belonging to a group of 3 people, the
            //list with ID 3 will be empty.

            for (int i = 0; i < groupSizes.Length; i++)
            {
                //We check if the list we are looking for is initialized
                if (buildingGroups[groupSizes[i]] == null) buildingGroups[groupSizes[i]] = new List<int>();

                //We add the ID of the person to the list which ID is his group's size
                buildingGroups[groupSizes[i]].Add(i);

                //Check if the group has been formed
                if (buildingGroups[groupSizes[i]].Count == groupSizes[i])
                {
                    //We add the current formed group to the list containing the result
                    groups.Add(buildingGroups[groupSizes[i]]);
                    buildingGroups[groupSizes[i]] = null;
                }
            }
            return groups;
            //If you have some improvements, leave them in the comment section below <3
            //If it was useful for you, don't forget to smash that sexy upvote button
        }

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
            System.Array.Sort(arr);
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
        #region Plus one - add one to an array with integers
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
        #endregion
        #region Sort Binary Numbers so that zeroes are first and ones last in array
        public static void SortBinaryArray(int[] A)
        {
            int zeros = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                    zeros++;
            }
            int k = 0;
            while (zeros-- != 0)
            {
                A[k++] = 0;
            }
            while(k < A.Length)
            {
                A[k++] = 1;
            }

            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
        }
        #endregion
        #region Find duplicate number
        public static void FindDuplicateItem(int[] array)
        {
            var duplicate = new HashSet<int>();

            foreach (int i in array)
            {
                if (duplicate.Contains(i))
                {
                    Console.WriteLine(string.Format("Duplicate number is {0}.", i));
                    break;
                }
                duplicate.Add(i);
            }
        }
        #endregion
        #region Find maximum array of consecutive values
        private static bool IsConsecutive(int[] a, int i, int j, int min, int max)
        {
            if (max - min != j - i)
            {
                return false;
            }

            HashSet<int> visited = new HashSet<int>();

            for (int k = i; k <= j; k++)
            {
                if (visited.Contains(a[k] - min))
                {
                    return false;
                }
                visited.Add(a[k] - min);
            }
            return true;
        }
        public static void FindMaxSubArray(int[]a)
        {
            int len = 1;
            int start = 0, end = 0;

            for (int i = 0; i < a.Length - 1; i++)
            {
                int min_val = a[i];
                int max_val = a[i];

                for (int j = i + 1; j < a.Length; j++)
                {
                    min_val = Math.Min(min_val, a[j]);
                    max_val = Math.Max(max_val, a[j]);

                    if (IsConsecutive(a,i,j,min_val,max_val))
                    {
                        if (len < max_val - min_val + 1)
                        {
                            len = max_val - min_val + 1;
                            start = i;
                            end = j;
                        }
                    }
                }
            }
            Console.WriteLine(String.Format("The largest sub-array is [{0},{1}]", start, end));
        }
        #endregion
        #region Find Maximum Length sub-array having given sum
        public static void MaxLengthSubArray(int[] a, int s)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            map.Add(0, -1);

            int sum = 0;
            int max_len = 0;
            int ending_index = -1;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i]; 

                if (!map.ContainsKey(sum))
                    map.Add(sum, i);

                if (map.ContainsKey(sum - s) && max_len < i - map[sum-s])
                {
                    max_len = i - map[sum - s];
                    ending_index = i;
                }
            }
            Console.WriteLine(string.Format("[{0},{1}]",(ending_index - max_len + 1),(ending_index)));
        }
        #endregion
        #region Find Maximum Length sub-array having equal number of 0s and 1s

        public static void MaxLengthSubArrayBinary(int[] a)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            map.Add(0, -1);

            int max_len = 0;
            int ending_index = -1;
            int sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += (a[i] == 0) ? -1 : 1;

                if (!map.ContainsKey(sum))
                    map.Add(sum,i);

                if (map.ContainsKey(sum) && max_len < i - map[sum])
                {
                    max_len = i - map[sum];
                    ending_index = i;
                }
                
            }
            if (ending_index != -1)
            {
                Console.WriteLine(String.Format("[{0},{1}]",ending_index - max_len + 1, ending_index));
            }
        }
        #endregion
        #region Sort Array of 0s, 1s, and 2s (Dutch National Flag Problem)

        public static void ThreeWayPartition(int[] a, int end)
        {
            int start = 0;
            int mid = 0;
            int pivot = 1;

            while (mid <= end)
            {
                if (a[mid] < pivot) // For element = 0
                {
                    Swap(a, start, mid);
                    start++;
                    mid++;
                }
                else if (a[mid] > pivot) // For element = 2
                {
                    Swap(a, mid, end);
                    end--;
                }
                else // For element = 1
                {
                    mid++;
                }
            }
        }
        private static void Swap(int[] a, int i, int j)
        {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }

        #endregion
        #region In-place merge two sorted arrays
        public static void MergeTwoArrays(int[] x, int[] y)
        {
            int len_x = x.Length;
            int len_y = y.Length;

            for (int i = 0; i < len_x; i++)
            {
                if (x[i] > y[0])
                {
                    int temp = x[i];
                    x[i] = y[0];
                    y[0] = temp;

                    int first = y[0];
                    int cnt; 

                    for (cnt = 1; cnt < len_y && y[cnt] < first; cnt++)
                    {
                        y[cnt - 1] = y[cnt];
                    }
                    y[cnt - 1] = first;
                }
            }
        }
        #endregion
    }
}
