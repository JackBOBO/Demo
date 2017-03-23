using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AlgorithmCode.Array;

namespace AlgorithmCodeTest.Array
{
    [TestClass]
    public class TestRotateArray
    {
        [TestMethod]
        public void TestRotateK()
        {
            bool result1 = true;
            int[] input1 = { 1, 2, 3, 4, 5 };
            int[] answer1 = { 4, 5, 1, 2, 3 };
            int[] output1 = RotateArray.RotateK(input1, 2);
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
            int[] output2 = RotateArray.RotateK(input2, 3);
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
    }
}
