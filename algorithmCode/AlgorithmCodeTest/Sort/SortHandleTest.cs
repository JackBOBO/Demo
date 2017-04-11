using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmCode.Sort;

namespace AlgorithmCodeTest.Sort
{
    [TestClass]
    public class SortHandleTest
    {
        [TestMethod]
        public void QuickSort()
        {
            int[] input = { 5, 7, 3, 1, 2 };
            int[] output = { 1, 2, 3, 5, 7 };
            int[] res = SortHandle.QuickSort(input, 0, input.Length - 1);

            bool isOK = true;
            for (int i = 0; i < output.Length; i++)
            {
                if (res[i] != output[i])
                {
                    isOK = false;
                    break;
                }
            }

            Assert.IsTrue(isOK);
        }
    }
}
