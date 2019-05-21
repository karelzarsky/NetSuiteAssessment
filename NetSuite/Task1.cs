﻿using System.Linq;

namespace NetSuite
{
    public class Task1
    {
        public int[] Move0ToEnd_FOR(int[] assignment)
        {
            var result = new int[assignment.Length];
            int counter = 0;
            foreach (var x in assignment)
            {
                if (x != 0)
                {
                    result[counter++] = x;
                }
            }
            return result;
        }

        public int[] Move0ToEnd_LINQ(int[] assignment)
        {
            var result = new int[assignment.Length];
            assignment.Where(x => x != 0).ToArray().CopyTo(result, 0);
            return result;
        }
    }

    public class Task2
    {
        public bool IsPalindromeFOR(string word)
        {
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsPalindromeREVERSE(string word)
        {
            return 0 == string.Compare(
                       new string(word.Substring(0, word.Length / 2).Reverse().ToArray()),
                       word.Substring((word.Length + 1) / 2, word.Length / 2));
        }
    }
}