using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Arrays.Strings
{
    public class LinkedInExercise
    {
        Dictionary<string, List<int>> EntryDictionary { get; set; }
        public LinkedInExercise()
        {
            EntryDictionary = new Dictionary<string, List<int>>();
        }
        public int ReturnValue(int n, List<int> arr)
        {
            arr.Sort();
            return arr[arr.Count - n];
        }
        public void Configure (string[] elements)
        {
            int index = 0;
            foreach (string item in elements)
            {
                if (EntryDictionary.ContainsKey(item))
                {
                    var IndexList = EntryDictionary[item];
                    IndexList.Add(index);
                    EntryDictionary[item] = IndexList;
                }
                else
                {
                    var IndexList = new List<int>();
                    IndexList.Add(index);
                    EntryDictionary.Add(item, IndexList);
                }
                index++;
            }
        }
        public int ShortestDistance (string wordOne, string wordTwo)
        {
            // ["The","Car","The", "Duck","Duck"] 3-2 = 1

            List<int> ListOne = EntryDictionary.ContainsKey(wordOne) ? EntryDictionary[wordOne] : null;
            List<int> ListTwo = EntryDictionary.ContainsKey(wordTwo) ? EntryDictionary[wordTwo] : null;

            int distance = 0;
            int index_wordOne = -1;
            int index_wordTwo = -1;

            if (ListOne != null && ListTwo != null)
            {
                for (int i = 0; i < ListOne.Count; i++)
                {
                    index_wordOne = ListOne[i];

                    for (int j = 0; j < ListTwo.Count; j++)
                    {
                        if (distance < Math.Min(index_wordOne, ListTwo[j]))
                        {
                            index_wordTwo = ListTwo[j];
                        }
                        distance = Math.Min(index_wordOne, ListTwo[j]);
                    }
                }
            }
            return index_wordOne == -1 && index_wordTwo == -1 ? -1 : index_wordTwo - index_wordOne;
        }
    }
}
