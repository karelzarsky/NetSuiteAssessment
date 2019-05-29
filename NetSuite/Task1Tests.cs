using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NetSuite
{
    [TestClass]
    public class Task1Tests
    {
        [TestMethod]
        public void MoveZeroesToEndTest()
        {
            int[] array = { 1, 3, 0, 8, 12, 0, 4, 0, 7 };
            int[] correct = { 1, 3, 8, 12, 4, 7, 0, 0, 0 };

            var result = array.MoveZeroesToEnd();

            Assert.AreEqual(correct.Length, result.Length);

            for (int i = 0; i < correct.Length; i++)
            {
                Assert.AreEqual(correct[i], result[i]);
            }
        }

        [TestMethod]
        public void MoveZeroesToEndInplaceTest()
        {
            int[] array = { 1, 3, 0, 8, 12, 0, 4, 0, 7 };
            int[] correct = { 1, 3, 8, 12, 4, 7, 0, 0, 0 };

            array.MoveZeroesToEndInplace();

            Assert.AreEqual(correct.Length, array.Length);

            for (int i = 0; i < correct.Length; i++)
            {
                Assert.AreEqual(correct[i], array[i]);
            }
        }
    }
}
