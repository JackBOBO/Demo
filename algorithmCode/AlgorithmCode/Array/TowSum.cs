using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCode.Array
{
    /// <summary>
    /// 两数之和
    /// </summary>
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
                else if (output[i] + output[j] > target)
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

        public static int[] HasMapSum(int[] arr, int target)
        {
            int[] result = { 0, 0 };

            if (arr == null || arr.Length < 2)
                return result;

            Dictionary<int, int> hm = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
                hm.Add(arr[i], i);

            for (int i = 0; i < arr.Length; i++)
            {
                if (hm.ContainsKey(target - arr[i]) && target != arr[i] * 2)
                {
                    result[0] = i;
                    result[1] = hm[target - arr[i]];
                    break;
                }
            }

            return result;
        }
    }
}
