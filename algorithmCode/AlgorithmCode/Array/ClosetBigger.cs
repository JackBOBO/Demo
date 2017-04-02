using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCode.Array
{
    /// <summary>
    /// 数位重组
    /// </summary>
    public class ClosetBigger
    {
        public static int[] Run(int[] x, int[] y)
        {
            int len = x.Length;
            int[] res = new int[len];

            x = x.OrderBy(num => num).ToArray();

            int xIndex = 0, resIndex = 0;
            bool[] used = new bool[len];

            for (int yIndex = 0; yIndex < len; yIndex++)
            {
                xIndex = 0;
                while (xIndex < len && (used[xIndex] || x[xIndex] < y[yIndex]))
                    xIndex++;

                res[resIndex++] = x[xIndex];
                used[xIndex] = true;
                if (xIndex == len - 1)
                    continue;

                if (x[xIndex] > y[yIndex])
                {
                    for (int i = 0; i < len; i++)
                    {
                        if (!used[i])
                            res[resIndex++] = x[i];
                    }
                    break;
                }
            }


            return res;
        }
    }
}
