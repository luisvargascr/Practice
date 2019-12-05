using System.Collections.Generic;

namespace DataStructures.Arrays.MultiDimensionalArrays
{
    public static class Zombies
    {
        public static int MinDays(int[,] grid)
        {
            Queue<int[]> q = new Queue<int[]>();
            int target = grid.GetUpperBound(0) * grid.GetUpperBound(1);
            int cnt = 0, res = 0;
            for (int i = 0; i < grid.GetUpperBound(0); i++)
            {
                for (int j = 0; j < grid.GetUpperBound(1); j++)
                {
                    if (grid[i,j] == 1)
                    {
                        q.Enqueue(new int[] { i, j });
                        cnt++;
                    }
                }
            }
            int[,] dirs = { { 0, 1 }, { 0, -1 }, { 1, 0 }, { -1, 0 } };
            while (q.Count > 0)
            {
                int size = q.Count;
                if (cnt == target)
                    return res;

                for (int i = 0; i < size; i++)
                {
                    int[] cur = q.Dequeue();
                    foreach (int dir in dirs)
                    {
                        int ni = cur[0] + dir;
                        int nj = cur[1] + dir;

                        if (ni >= 0 && ni < grid.GetUpperBound(0) && nj >= 0 && nj < grid.GetUpperBound(1) && grid[ni,nj] == 0)
                        {
                            cnt++;
                            q.Enqueue(new int[] { ni, nj });
                            grid[ni,nj] = 1;
                        }
                    }
                }
                res++;
            }
            return res;
        }
    }
}
