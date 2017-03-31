using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCode.Array
{
    public class MaxIndexDistance
    {
        public static int Run(int[] arr)
        {
            if (arr == null || arr.Length < 2)
                return 0;

            bool[] inDescSeq = new bool[arr.Length];
            int min = arr[0], n = arr.Length;
            inDescSeq[0] = true;
            for (int k = 1; k < n; k++)
            {
                if (arr[k] < min)
                {
                    inDescSeq[k] = true;
                    min = arr[k];
                }
            }

            int maxDist = 0, i = n - 1, j = n - 1;
            while (i >= 0)
            {
                if (!inDescSeq[i])
                {
                    i--;
                    continue;
                }

                while (arr[j] <= arr[i] && j > i)
                    j--;

                if ((j - i) > maxDist)
                    maxDist = j - i;

                i--;
            }

            return maxDist;
        }
    }
}
