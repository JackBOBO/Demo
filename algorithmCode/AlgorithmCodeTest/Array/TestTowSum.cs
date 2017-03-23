using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmCode.Array;

namespace AlgorithmCodeTest.Array
{
    [TestClass]
    public class TestTowSum
    {
        [TestMethod]
        public void TestHasSum()
        {
            int[] input1 = { 3, 7, 5, 1 };
            int[] input2 = { 1, 2, 6, 7 };

            bool output1 = TowSum.HasSum(input1, 10);
            bool output2 = TowSum.HasSum(input2, 10);

            Assert.IsTrue(output1);
            Assert.IsFalse(output2);
        }

        [TestMethod]
        public void TestHasMapSum()
        {
            int[] input1 = { 5, 3, 1, 7, 2, 4 };
            int[] input2 = { 5, 3, 1, 7, 3, 2, 4 };
            int[] input3 = { 5, 3, 1, 7, 2, 7, 4 };

            int[] output1 = TowSum.HasMapSum(input1, 10);
            Assert.IsTrue(output1[0] == 1 && output1[1] == 3);

            int[] output2 = TowSum.HasMapSum(input1, 9);
            Assert.IsTrue(output2[0] == 0 && output2[1] == 5);

            int[] output3 = TowSum.HasMapSum(input1, 22);
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
    }
}
