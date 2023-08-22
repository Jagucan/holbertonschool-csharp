using System;
using System.Collections.Generic;
using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMaxInteger()
        {
            List<int> myList1 = new List<int>() { 98, -10, 0, 32, 972, 12, 1024, -727, -98, 50, 8 };
            int maxNum1 = Operations.Max(myList1);
            Assert.AreEqual(1024, maxNum1);

            List<int> myList2 = new List<int>() {98, -10, 1024, -727, -98, 0, 3200, 972, 12, 50, 8};
            int maxNum2 = Operations.Max(myList2);
            Assert.AreEqual(3200, maxNum2);

            List<int> myList3 = new List<int>() {};
            int maxNum3 = Operations.Max(myList3);
            Assert.AreEqual(0, maxNum3);

            List<int> myList4 = new List<int>() {0};
            int maxNum4 = Operations.Max(myList4);
            Assert.AreEqual(0, maxNum4);
        }
    }
}
