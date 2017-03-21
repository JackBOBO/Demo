using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmCode.TowSum;

namespace AlgorithmCodeTest
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
    }
}
