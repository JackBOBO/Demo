using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmCode.Array;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmCodeTest.Array
{
    [TestClass]
    public class ArrayHandleTest
    {
        [TestMethod]
        public void TestHasSum()
        {
            int[] input1 = { 3, 7, 5, 1 };
            int[] input2 = { 1, 2, 6, 7 };

            bool output1 = ArrayHandle.HasSum(input1, 10);
            bool output2 = ArrayHandle.HasSum(input2, 10);

            Assert.IsTrue(output1);
            Assert.IsFalse(output2);
        }

        [TestMethod]
        public void TestHasMapSum()
        {
            int[] input1 = { 5, 3, 1, 7, 2, 4 };
            int[] input2 = { 5, 3, 1, 7, 3, 2, 4 };
            int[] input3 = { 5, 3, 1, 7, 2, 7, 4 };

            int[] output1 = ArrayHandle.HasMapSum(input1, 10);
            Assert.IsTrue(output1[0] == 1 && output1[1] == 3);

            int[] output2 = ArrayHandle.HasMapSum(input1, 9);
            Assert.IsTrue(output2[0] == 0 && output2[1] == 5);

            int[] output3 = ArrayHandle.HasMapSum(input1, 22);
            Assert.IsTrue(output3[0] == 0 && output3[1] == 0);
        }

        [TestMethod]
        public void TestHashMapHasSum()
        {
            HashMapTowSum towSum1 = new HashMapTowSum();
            towSum1.save(1);
            towSum1.save(3);
            towSum1.save(5);
            towSum1.save(7);
            towSum1.save(1);
            towSum1.save(9);

            Assert.IsTrue(towSum1.test(10));

            HashMapTowSum towSum2 = new HashMapTowSum();
            towSum2.save(1);
            towSum2.save(2);
            towSum2.save(5);
            towSum2.save(7);
            towSum2.save(1);
            towSum2.save(7);

            Assert.IsFalse(towSum2.test(10));

            HashMapTowSum towSum3 = new HashMapTowSum();
            towSum3.save(1);
            towSum3.save(3);
            towSum3.save(5);
            towSum3.save(7);
            towSum3.save(1);
            towSum3.save(7);

            Assert.IsTrue(towSum3.test(10));
        }

        [TestMethod]
        public void TestCheckPairable()
        {
            int k = 7;
            int[] inputs1 = { 10, 25 };
            int[] inputs2 = { 10, 25, 5, 30 };
            int[] inputs3 = { 10, 21, 5, 31 };

            Assert.IsTrue(ArrayHandle.CheckPairable(inputs1, k));
            Assert.IsTrue(ArrayHandle.CheckPairable(inputs2, k));
            Assert.IsFalse(ArrayHandle.CheckPairable(inputs3, k));
        }

        [TestMethod]
        public void TestClosetBigger()
        {
            int[] xInput = { 5, 3, 2, 1 };
            int[] yInput = { 2, 4, 1, 0 };
            int[] outPut = { 2, 5, 1, 3 };

            int[] res = ArrayHandle.ClosetBigger(xInput, yInput);

            bool isOK = true;
            for (int i = 0; i < res.Length; i++)
            {
                if (outPut[i] != res[i])
                {
                    isOK = false;
                    break;
                }
            }

            Assert.IsTrue(isOK);
        }

        [TestMethod]
        public void TestTopKI()
        {
            int[] outpus = { 1, 2, 3 };

            int[] inputs = { 5, 7, 3, 1, 2 };
            int[] res1 = ArrayHandle.getTopKI(inputs, 3);

            int[] inputs1 = { 2, 5, 3, 1, 7 };
            int[] res2 = ArrayHandle.getTopKI(inputs1, 3);

            bool isOK = true;
            for (int i = 0; i < outpus.Length; i++)
            {
                if (res1[i] != outpus[i] || res2[i] != outpus[i])
                {
                    isOK = false;
                    break;
                }

            }

            Assert.IsTrue(isOK);
        }

        [TestMethod]
        public void TestMaxIndexDistance()
        {
            int[] arr1 = { 5, 3, 4, 0, 1, 4, 1 };
            int[] arr2 = { 1, 3, 4, 0, 1, 4, 1 };

            Assert.IsTrue(4.Equals(ArrayHandle.MaxIndexDistance(arr1)));
            Assert.IsTrue(5.Equals(ArrayHandle.MaxIndexDistance(arr2)));
        }


        [TestMethod]
        public void TestRotateK()
        {
            bool result1 = true;
            int[] input1 = { 1, 2, 3, 4, 5 };
            int[] answer1 = { 4, 5, 1, 2, 3 };
            int[] output1 = ArrayHandle.RotateK(input1, 2);
            for (int i = 0; i < output1.Length; i++)
            {
                if (output1[i] != answer1[i])
                {
                    result1 = false;
                    break;
                }
            }

            Assert.IsTrue(result1);

            bool result2 = true;
            int[] input2 = { 10, 9, 8, 7, 6, 5, 4 };
            int[] answer2 = { 7, 6, 5, 4, 10, 9, 8 };
            int[] output2 = ArrayHandle.RotateK(input2, 3);
            for (int i = 0; i < output2.Length; i++)
            {
                if (output2[i] != answer2[i])
                {
                    result1 = false;
                    break;
                }
            }

            Assert.IsTrue(result2);

        }


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
        public void MergeInterval()
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
