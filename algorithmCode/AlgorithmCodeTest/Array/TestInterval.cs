using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmCode.Array;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmCodeTest.Array
{
    /// <summary>
    /// 重叠区间数单元测试
    /// </summary>
    [TestClass]
    public class TestInterval
    {
        [TestMethod]
        public void TestOverlappingCount()
        {
            Interval[] arr = new Interval[4];
            arr[0] = new Interval(1, 5);
            arr[1] = new Interval(10, 15);
            arr[2] = new Interval(5, 10);
            arr[3] = new Interval(20, 30);

            Assert.IsTrue(3.Equals(Interval.GetOverlappingCount(arr)));
        }

        /// <summary>
        /// 测试为有序、无重叠区间插入新区间，并保持无重叠。
        /// </summary>
        [TestMethod]
        public void TestInsert()
        {
            Interval right = new Interval(1, 10);
            Interval[] arr = new Interval[2];
            arr[0] = new Interval(1, 5);
            arr[1] = new Interval(6, 10);

            IList<Interval> res = Interval.Insert(arr, new Interval(4, 6));

            Assert.IsTrue(right == res.First());
        }

        /// <summary>
        /// 合并区间
        /// </summary>
        [TestMethod]
        public void Merge()
        {
            Interval[] inputs = new Interval[5];
            inputs[0] = new Interval(4, 7);
            inputs[1] = new Interval(1, 5);
            inputs[2] = new Interval(6, 10);
            inputs[3] = new Interval(4, 6);
            inputs[4] = new Interval(15, 20);

            Interval[] outputs = new Interval[2];
            outputs[0] = new Interval(1, 10);
            outputs[1] = new Interval(15, 20);


            Interval[] result = Interval.Merge(inputs).ToArray();

            bool isOK = true;
            if (outputs.Length == result.Length)
            {
                for (int i = 0; i < outputs.Length; i++)
                {
                    if (outputs[i] != result[i])
                    {
                        isOK = false;
                        break;
                    }
                }
            }
            else
            {
                isOK = false;
            }

            Assert.IsTrue(isOK);
        }
    }
}
