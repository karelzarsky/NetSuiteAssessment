using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NetSuite
{
    [TestClass]
    public class Task2Tests
    {
        [TestMethod]
        public void IsPalindromeFORTest()
        {
            Assert.IsTrue(new Task2().IsPalindrome_FOR("dabbad"));
            Assert.IsTrue(new Task2().IsPalindrome_FOR("dabcbad"));
            Assert.IsFalse(new Task2().IsPalindrome_FOR("Dabcbad"));
            Assert.IsFalse(new Task2().IsPalindrome_FOR("Dabbad"));
        }

        [TestMethod]
        public void IsPalindromeREVERSETest()
        {
            Assert.IsTrue(new Task2().IsPalindrome_StringReverse("dabcbad"));
            Assert.IsTrue(new Task2().IsPalindrome_StringReverse("dabbad"));
            Assert.IsFalse(new Task2().IsPalindrome_StringReverse("Dabbad"));
            Assert.IsFalse(new Task2().IsPalindrome_StringReverse("Dabcbad"));
        }

    }
}