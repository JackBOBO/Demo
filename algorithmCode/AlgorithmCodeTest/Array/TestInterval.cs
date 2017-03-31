using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmCode.Array;

namespace AlgorithmCodeTest.Array
{
    [TestClass]
    public class TestInterval
    {
        [TestMethod]
        public void TestOverlappingCount() {
            Interval[] arr = new Interval[4];
            arr[0] = new Interval(1, 5);
            arr[1] = new Interval(10, 15);
            arr[2] = new Interval(5, 10);
            arr[3] = new Interval(20, 30);

            Assert.IsTrue(3.Equals(Interval.GetOverlappingCount(arr)));
        }
    }
}
