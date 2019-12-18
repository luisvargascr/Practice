using System;
using System.Collections.Generic;

namespace DataStructures.Arrays.OneDimensionalArrays
{
    public static partial class ArrayExercises
    {
        /* Write a program in C# Sharp to store elements in an array and print it  */

        public static void StoreElementsInArray()
        {
            List<int> nums = new List<int>();
            int size = 0;
            var PressedKey = string.Empty;

            do
            {
                Console.Write(string.Format("element - {0} : ", size));
                PressedKey = Console.ReadLine();

                if (int.TryParse(PressedKey, out int val))
                {
                    nums.Add(val);
                }
                size++;

                if (PressedKey.Equals("q", StringComparison.InvariantCultureIgnoreCase))
                {
                    PrintArrayValues(nums.ToArray());
                    PrintArrayValuesReverseOrder(nums.ToArray());
                    FindSumAllElementsOfArray(nums.ToArray());
                    CopyElementsFromArrayOneToArrayTow(nums.ToArray());
                    GetTotalDuplicateCount(nums.ToArray());
                    PrintAllUniqueElements(nums.ToArray());
                }
            } while (!PressedKey.Equals("q", StringComparison.InvariantCultureIgnoreCase));
        }

        private static void PrintArrayValues(int[] nums)
        {
            Console.Write("\nElements in array are: ");
            foreach (var i in nums)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.WriteLine("\n");
        }
        private static void PrintArrayValuesReverseOrder(int[] nums)
        {
            Console.Write("\nElements in array in reversed order are: ");
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                Console.Write(nums[i].ToString() + " ");
            }
            Console.WriteLine("\n");
        }
        private static int FindSumAllElementsOfArray(int[] nums)
        {
            int sum = 0;

            foreach (int i in nums)
            {
                sum += i;
            }
            Console.WriteLine(string.Format("Sum of all elements stored in the array is: {0}", sum));
            return sum;
        }
        private static void CopyElementsFromArrayOneToArrayTow(int[] nums)
        {
            int[] arr2 = new int[nums.Length];
            Console.WriteLine("\nhe elements copied into the second array are: ");

            for (int i = 0; i < nums.Length; i++)
            {
                arr2[i] = nums[i];
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine("\n");
        }
        private static void GetTotalDuplicateCount(int[] nums)
        {
            var Dic = new Dictionary<int, int>();
            int TotalDuplicates = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (Dic.ContainsKey(nums[i]))
                    Dic[nums[i]] += 1;
                else
                    Dic.Add(nums[i], 1);
            }
            foreach (KeyValuePair<int, int> keyValuePair in Dic)
            {
                if (keyValuePair.Value > 1)
                {
                    TotalDuplicates++;
                }
            }
            if (TotalDuplicates > 0)
            {
                Console.WriteLine(string.Format("\nTotal number of duplicate elements found in the array is: {0}", TotalDuplicates));
            }
            else
            {
                Console.WriteLine("\nNo duplicates found");
            }
        }
        private static void PrintAllUniqueElements(int[] nums)
        {
            var Unique = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (Unique.Contains(nums[i]))
                    Unique.Remove(nums[i]);
                else
                    Unique.Add(nums[i]);
            }
            Console.WriteLine("\nThe unique elements found in the array are: ");
            foreach (int val in Unique)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine("\n");
        }
        public static void MergeToArraysSameSizeSorted(int[] arr1, int[] arr2)
        {
            int[] arr3 = new int[arr1.Length + arr2.Length];
            Array.Copy(arr1, 0, arr3, 0, arr1.Length);
            Array.Copy(arr2, 0, arr3, arr1.Length, arr2.Length);
            Array.Sort(arr3);

            Console.WriteLine("\nThe merged array in ascending order is: ");
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr3[i] + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
