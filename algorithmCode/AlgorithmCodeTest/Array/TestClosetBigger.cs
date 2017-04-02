using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmCode.Array;

namespace AlgorithmCodeTest.Array
{
    [TestClass]
    public class TestClosetBigger
    {
        [TestMethod]
        public void TestClosetBigger1()
        {
            int[] xInput = { 5, 3, 2, 1 };
            int[] yInput = { 2, 4, 1, 0 };
            int[] outPut = { 2, 5, 1, 3 };

            int[] res = ClosetBigger.Run(xInput, yInput);

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
    }
}
