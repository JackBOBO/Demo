using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCode.Array
{
    /// <summary>
    /// 数组配对
    /// </summary>
    public class CheckPairable
    {
        public static bool Run(int[] numbers, int k)
        {
            if (k <= 0)
                return false;

            int[] counts = new int[k];
            foreach (int num in numbers)
                counts[num % k]++;

            if (counts[0] % 2 != 0)
                return false;

            if (k % 2 == 0)
            {
                if (counts[k / 2] % 2 != 0)
                {
                    return false;
                }
            }

            for (int i = 1; i <= k / 2; i++)
            {
                if (counts[i] != counts[k - i])
                    return false;
            }

            return true;
        }
    }
}
