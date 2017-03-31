using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmCode.Array;

namespace AlgorithmCodeTest.Array
{

    [TestClass]
    public class TestMaxIndexDistance
    {

        [TestMethod]
        public void TestMaxIndex()
        {
            int[] arr1 = { 5, 3, 4, 0, 1, 4, 1 };
            int[] arr2 = { 1, 3, 4, 0, 1, 4, 1 };

            Assert.IsTrue(4.Equals(MaxIndexDistance.Run(arr1)));
            Assert.IsTrue(5.Equals(MaxIndexDistance.Run(arr2)));
        }

    }
}
