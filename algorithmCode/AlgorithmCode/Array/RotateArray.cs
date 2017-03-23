using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCode.Array
{
    public class RotateArray
    {
        public static int[] RotateK(int[] arr, int k)
        {
            if (arr == null || k >= arr.Length)
                return arr;

            Reverse(arr, 0, arr.Length - 1);
            Reverse(arr, 0, k - 1);
            Reverse(arr, k, arr.Length - 1);

            return arr;
        }

        public static void Reverse(int[] arr, int start, int end)
        {
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
    }
}
