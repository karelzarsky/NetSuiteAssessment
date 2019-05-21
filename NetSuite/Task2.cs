using System.Linq;

namespace NetSuite
{
    public class Task2
    {
        public bool IsPalindrome_FOR(string word)
        {
            for (int i = 0; i < word.Length / 2; i++)
                if (word[i] != word[word.Length - i - 1])
                    return false;
            return true;
        }

        public bool IsPalindrome_StringReverse(string word)
        {
            return string.Compare(
                       new string(word.Substring(0, word.Length / 2).Reverse().ToArray()),
                       word.Substring((word.Length + 1) / 2, word.Length / 2)) == 0;
        }
    }
}