using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCode.Array
{
    public class TopKI
    {
        private static int partition(int[] data, int start, int end)
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

        public static void getTopK(int[] data, int k)
        {
            int start = 0, end = data.Length - 1;
            int index = partition(data, start, end);
            while (index != k - 1)
            {
                if (index > k - 1)
                {
                    end = index - 1;
                    index = partition(data, start, end);
                }
                else
                {
                    start = index + 1;
                    index = partition(data, start, end);
                }
            }

            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(data[i].ToString());
            }
        }
    }
}
