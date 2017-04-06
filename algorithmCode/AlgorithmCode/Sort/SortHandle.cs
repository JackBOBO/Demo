using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCode.Sort
{
    public class SortHandle
    {
        /// <summary>
        /// 快排分区函数
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="low"></param>
        /// <param name="hight"></param>
        /// <returns></returns>
        private static int Partition(int[] arr, int low, int hight)
        {
            int key = arr[low];
            while (low < hight)
            {
                while (arr[hight] >= key && hight > low)
                    --hight;

                arr[low] = arr[hight];

                while (arr[low] <= key && hight > low)
                    ++low;

                arr[hight] = arr[low];
            }

            arr[low] = key;

            return hight;
        }

        /// <summary>
        /// 快速排序
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="low"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static int[] QuickSort(int[] arr, int low, int height)
        {
            if (low > height)
                return arr;

            int index = Partition(arr, low, height);
            Partition(arr, low, index - 1);
            Partition(arr, index + 1, height);
            return arr;
        }
    }
}
