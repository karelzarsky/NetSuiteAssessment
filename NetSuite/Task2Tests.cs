using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NetSuite
{
    [TestClass]
    public class Task2Tests
    {
        [TestMethod]
        public void IsPalindromeTest()
        {
            Assert.IsTrue(new Task2().IsPalindrome("dabbad"));
            Assert.IsTrue(new Task2().IsPalindrome("dabcbad"));
            Assert.IsFalse(new Task2().IsPalindrome("Dabcbad"));
            Assert.IsFalse(new Task2().IsPalindrome("Dabbad"));
        }
    }
}