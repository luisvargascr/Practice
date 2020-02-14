using System.Collections.Generic;

public static class CustomSortString
{
    public static string SortString(string S, string T)
    {

        int S_Length = S.Length;
        int T_Length = T.Length;

        Dictionary<char, int> Unique = new Dictionary<char, int>();
        char[] newval = new char[T.Length];

        for (int i = 0; i < S.Length; i++)
        {
            Unique.Add(S[i], i);
        }
        for (int i = 0; i < T.Length; i++)
        {
            newval[i] = T[i];
        }
        for (int j = 0; j < T.Length; j++)
        {
            for (int k = j; k < T.Length - 1; k++)
            {
                if (Unique.ContainsKey(T[j]))
                {
                    if (j != Unique[T[j]])
                    {
                        //char tmp = newval[Unique[T[j]]];
                        newval[Unique[T[j]]] = T[j];
                        //newval[k] = tmp;
                    }
                }
            }
        }
        return new string(newval);
    }
}