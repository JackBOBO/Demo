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
    public class HashMapTowSum
    {
        private Dictionary<int, int> hm = new Dictionary<int, int>();

        public void save(int input)
        {
            if (hm.ContainsKey(input))
                hm[input] = hm[input] + 1;
            else
                hm.Add(input, 1);
        }

        public bool test(int target)
        {
            foreach (var it in hm)
            {
                int val = it.Key;
                if (hm.ContainsKey(target - val))
                {
                    bool isDouble = target == val * 2;
                    if (!(isDouble && hm[val] == 1))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
