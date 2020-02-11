using System;
using System.Collections.Generic;

namespace LeetCodePractice
{
    public class SolutionOne
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var InternalStack = new Stack<int>();
            var ListOfPos = new List<int>();
            int cnt = 0;

            while (cnt < nums.Length)
            {
                if (InternalStack.Count <= 0)
                {
                    InternalStack.Push(nums[cnt]);
                    cnt++;
                }
                else
                {
                    int NewSum = InternalStack.Peek() + nums[cnt];
                    if (NewSum == target)
                    {
                        ListOfPos.Add(cnt - 1);
                        ListOfPos.Add(cnt);
                        return ListOfPos.ToArray();
                    }
                    InternalStack.Pop();
                }
            }
            return ListOfPos.ToArray();
        }

        public IList<int> FindMinHeightTrees(int n, int[][] edges)
        {
            List<int> RootLabels = new List<int>();

            Dictionary<int, int> EdgeHits = new Dictionary<int, int>();


            for (int i = 0; i < edges.Length; i++)
            {
                for (int j = 0; j < edges[i].Length; j++)
                {
                    // Console.WriteLine(edges[i][j]);

                    if (EdgeHits.Count == 0)
                    {
                        EdgeHits.Add(edges[i][j], 1);
                    }
                    else
                    {
                        if (EdgeHits.ContainsKey(edges[i][j]))
                        {
                            EdgeHits[edges[i][j]]++;
                        }
                        else
                        {
                            EdgeHits.Add(edges[i][j], 1);
                        }
                    }
                }
            }
            foreach (var MyLocalKeys in EdgeHits.Keys)
            {
                // Console.WriteLine(string.Format("KEY {0}, VALUE {1}", MyLocalKeys, EdgeHits[MyLocalKeys]));
                // Console.WriteLine("\n");

                if (EdgeHits[MyLocalKeys] > 2)
                {
                    RootLabels.Add(MyLocalKeys);
                    // Console.WriteLine("Result:");
                    //Console.WriteLine(EdgeHits[MyLocalKeys]);
                }
            }
            return RootLabels;
        }

    }
}
