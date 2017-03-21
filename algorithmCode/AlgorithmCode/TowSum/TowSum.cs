using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCode.TowSum
{
    public class TowSum
    {
        public static bool HasSum(int[] arr, int target)
        {
            bool result = false;

            if (arr == null || arr.Length < 2)
                return result;

            int[] output = arr.OrderBy(item => item).ToArray();

            int i = 0, j = output.Length - 1;
            while (i < j)
            {
                if (output[i] + output[j] == target)
                {
                    result = true;
                    break;
                }
                else if (output[i] + output[j] == target)
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }

            return result;
        }
    }
}
