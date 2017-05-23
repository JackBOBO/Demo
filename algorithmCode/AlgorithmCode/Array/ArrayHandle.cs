using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCode.Array
{
    public static class ArrayHandle
    {

        /// <summary>
        /// 两数之和
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="target"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 两数之和
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="target"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 数组配对
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static bool CheckPairable(int[] numbers, int k)
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

        /// <summary>
        /// 数位重组
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int[] ClosetBigger(int[] x, int[] y)
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

        /// <summary>
        /// 最大下标
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int MaxIndexDistance(int[] arr)
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

        /// <summary>
        /// 数组旋转
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int[] RotateK(int[] arr, int k)
        {
            if (arr == null || k >= arr.Length)
                return arr;

            Reverse(arr, 0, arr.Length - 1);
            Reverse(arr, 0, k - 1);
            Reverse(arr, k, arr.Length - 1);

            return arr;
        }

        /// <summary>
        /// 倒置数组
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int[] getTopKI(int[] data, int k)
        {
            int start = 0, end = data.Length - 1;
            int index = Partition(data, start, end);
            while (index != k - 1)
            {
                if (index > k - 1)
                {
                    end = index - 1;
                    index = Partition(data, start, end);
                }
                else
                {
                    start = index + 1;
                    index = Partition(data, start, end);
                }
            }

            return data;
        }

        /// <summary>
        /// 快速分区函数
        /// </summary>
        /// <param name="data"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        private static int Partition(int[] data, int start, int end)
        {
            if (start > end)
                return -1;

            int index = start;

            int tmp = data[index];
            data[index] = data[end];
            data[end] = tmp;

            for (int i = start; i < end; i++)
            {
                if (data[i] <= data[end])
                {
                    if (i != index)
                    {
                        tmp = data[index];
                        data[index] = data[i];
                        data[i] = tmp;
                    }

                    index++;
                }
            }

            tmp = data[end];
            data[end] = data[index];
            data[index] = tmp;

            return index;
        }

        public static int[] getTopKII(int[] data, int k)
        {

            int start = 0, end = data.Length - 1;
            int last = -1;
            int currSum = 0;

            int index = Partition(data, start, end, ref currSum);

            while (index >= 0)
            {
                if (currSum >= k)
                {
                    last = index;
                    end = index - 1;
                    index = Partition(data, start, end, ref currSum);
                }
                else
                {
                    start = index + 1;
                    k = k - currSum;
                    index = Partition(data, start, end, ref currSum);
                }
            }

            int[] res = new int[last + 1];
            for (int i = 0; i <= last; i++)
                res[i] = data[i];

            return res;
        }

        private static int Partition(int[] data, int start, int end, ref int currSum)
        {
            if (start > end)
                return -1;

            int index = start;

            int tmp = data[index];
            data[index] = data[end];
            data[end] = tmp;

            for (int i = start; i < end; i++)
            {
                if (data[i] <= data[end])
                {
                    if (i != index)
                    {
                        tmp = data[index];
                        data[index] = data[i];
                        data[i] = tmp;
                    }

                    index++;
                }
            }

            tmp = data[end];
            data[end] = data[index];
            data[index] = tmp;

            return index;
        }
    }
}
