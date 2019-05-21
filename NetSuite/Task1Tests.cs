using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NetSuite
{
    [TestClass]
    public class Task1Tests
    {
        public int[] example = { 1, 3, 0, 8, 12, 0, 4, 0, 7 };
        public int[] correct = { 1, 3, 8, 12, 4, 7, 0, 0, 0 };

        [TestMethod]
        public void Move0ToEnd_LINQTest()
        {
            var result = new Task1().MoveZeroesToEnd_LINQ(example);

            Assert.AreEqual(correct.Length, result.Length);

            for (int i = 0; i < correct.Length; i++)
            {
                Assert.AreEqual(correct[i], result[i]);
            }
        }

        [TestMethod]
        public void Move0ToEnd_FORTest()
        {
            var result = new Task1().MoveZeroesToEnd_FOR(example);

            Assert.AreEqual(correct.Length, result.Length);

            for (int i = 0; i < correct.Length; i++)
            {
                Assert.AreEqual(correct[i], result[i]);
            }
        }
    }
}
