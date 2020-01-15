using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObstacleCourseTwoClassLibrary;

namespace ObstacleCourseTwoUnitTests
{
    [TestClass]
    public class Part2UnitTest
    {
        [TestMethod]
        public void TestSetFirstElementToOne()
        {
            int[] arr = new int[] { 0, 1, 2, 3, 4, 5 };
            Part2.setFirstElementToOne(arr);
            Assert.AreEqual(1, arr[0]);
        }

        [TestMethod]
        public void TestCalculateSum()
        {
            int[] arr = new int[] { 0, 1, 2, 3, 4, 5 };
            int result = Part2.CalculateSum(arr);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void TestCalculateSumOfPositive()
        {
            int[] arr = new int[] { 0, 1, -2, 3, -4, 5 };
            int result = Part2.CalculateSumOfPositive(arr);
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void TestCalculateSumOfNegative()
        {
            int[] arr = new int[] { 0, 1, -2, 3, -4, 5 };
            int result = Part2.CalculateSumOfNegative(arr);
            Assert.AreEqual(-6, result);
        }

        [TestMethod]
        public void TestReplaceNegativeWithZero()
        {
            int[] arr = new int[] { 0, 1, -2, 3, -4, 5 };
            Part2.ReplaceNegativeWithZero(arr);
            CollectionAssert.AreEqual(new int[] { 0, 1, 0, 3, 0, 5 }, arr);
        }

        [TestMethod]
        public void TestSetAllValuesTo3()
        {
            int[] arr = new int[] { 0, 1, -2, 3, -4, 5 };
            Part2.SetAllValuesTo3(arr);
            CollectionAssert.AreEqual(new int[] { 3, 3, 3, 3, 3, 3 }, arr);
        }

        [TestMethod]
        public void TestSetAllValuesToN()
        {
            int[] arr = new int[] { 0, 1, -2, 3, -4, 5 };
            Part2.SetAllValuesToN(arr, 3);
            CollectionAssert.AreEqual(new int[] { 3, 3, 3, 3, 3, 3 }, arr);
            Part2.SetAllValuesToN(arr, 4);
            CollectionAssert.AreEqual(new int[] { 4, 4, 4, 4, 4, 4 }, arr);
        }

        [TestMethod]
        public void TestDoubleEachNumber()
        {
            int[] arr = new int[] { 0, 1, 2, 3, 4, 5 };
            Part2.DoubleEachNumber(arr);
            CollectionAssert.AreEqual(new int[] { 0, 2, 4, 6, 8, 10 }, arr);
        }

        [TestMethod]
        public void TestArray1to10()
        {
            int[] result = Part2.Array1to10();
            CollectionAssert.AreEqual(new int[] { 1,2,3,4,5,6,7,8,9,10 }, result);
        }

        [TestMethod]
        public void TestArray10to20()
        {
            int[] result = Part2.Array10to20();
            CollectionAssert.AreEqual(new int[] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }, result);
        }

        [TestMethod]
        public void TestArray30to20()
        {
            int[] result = Part2.Array30to20();
            CollectionAssert.AreEqual(new int[] { 30, 29, 28, 27, 26, 25, 24, 23, 22, 21, 20 }, result);
        }

        [TestMethod]
        public void TestOneToN()
        {
            int[] result = Part2.OneToN(5);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, result);
            int[] result2 = Part2.OneToN(7);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5, 6, 7 }, result2);
        }

    }
}
