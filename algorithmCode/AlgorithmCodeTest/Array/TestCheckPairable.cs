using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmCode.Array;

namespace AlgorithmCodeTest.Array
{
    [TestClass]
    public class TestCheckPairable
    {
        [TestMethod]
        public void TestCheckPairable1()
        {
            int k = 7;
            int[] inputs1 = { 10, 25 };
            int[] inputs2 = { 10, 25, 5, 30 };
            int[] inputs3 = { 10, 21, 5, 31 };

            Assert.IsTrue(CheckPairable.Run(inputs1, k));
            Assert.IsTrue(CheckPairable.Run(inputs2, k));
            Assert.IsFalse(CheckPairable.Run(inputs3, k));
        }
    }
}
