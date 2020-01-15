using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObstacleCourseTwoClassLibrary;

namespace ObstacleCourseTwoUnitTests
{
    [TestClass]
    public class EasyPartUnitTests
    {
        public EasyPartUnitTests()
        {
        }

        [TestMethod]
        public void TestCreateArray5ElementsAndFillWithOnesNoLoop()
        {
            int[] result = EasyPart.CreateArray5ElementsAndFillWithOnesNoLoop();
            CollectionAssert.AreEqual(new int[] { 1, 1, 1, 1, 1 }, result);
        }
        [TestMethod]
        public void TestCreateArray5ElementsAndFillWithOnesForLoop()
        {
            int[] result = EasyPart.CreateArray5ElementsAndFillWithOnesForLoop();
            CollectionAssert.AreEqual(new int[] { 1, 1, 1, 1, 1 }, result);
        }

        [TestMethod]
        public void TestCreateArrayNElementsAndFillWithTwosForLoop()
        {
            int[] result = EasyPart.CreateArrayNElementsAndFillWithTwosForLoop(4);
            CollectionAssert.AreEqual(new int[] { 2, 2, 2, 2 }, result);
        }

        [TestMethod]
        public void TestCreateArrayNElementsAndFillWithThreesForLoop()
        {
            int[] result = EasyPart.CreateArrayNElementsAndFillWithThreesForLoop(5);
            CollectionAssert.AreEqual(new int[] { 3, 3, 3, 3, 3 }, result);
        }
    }
}

