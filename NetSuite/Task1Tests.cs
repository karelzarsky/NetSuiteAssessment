using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var result = new Task1().Move0ToEnd_LINQ(example);

            Assert.AreEqual(correct.Length, result.Length);

            for (int i = 0; i < correct.Length; i++)
            {
                Assert.AreEqual(correct[i], result[i]);
            }
        }

        [TestMethod]
        public void Move0ToEnd_FORTest()
        {
            var result = new Task1().Move0ToEnd_FOR(example);

            Assert.AreEqual(correct.Length, result.Length);

            for (int i = 0; i < correct.Length; i++)
            {
                Assert.AreEqual(correct[i], result[i]);
            }
        }
    }

    [TestClass]
    public class Task2Tests
    {
        [TestMethod]
        public void IsPalindromeFORTest()
        {
            Assert.IsTrue(new Task2().IsPalindromeFOR("dabbad"));
            Assert.IsTrue(new Task2().IsPalindromeFOR("dabcbad"));
            Assert.IsFalse(new Task2().IsPalindromeFOR("Dabcbad"));
            Assert.IsFalse(new Task2().IsPalindromeFOR("Dabbad"));
        }

        [TestMethod]
        public void IsPalindromeREVERSETest()
        {
            Assert.IsTrue(new Task2().IsPalindromeREVERSE("dabcbad"));
            Assert.IsTrue(new Task2().IsPalindromeREVERSE("dabbad"));
            Assert.IsFalse(new Task2().IsPalindromeREVERSE("Dabbad"));
            Assert.IsFalse(new Task2().IsPalindromeREVERSE("Dabcbad"));
        }

    }
}
