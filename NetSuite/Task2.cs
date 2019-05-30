namespace NetSuiteAssessment
{
    /*
     2. A palindrome is a word that reads the same backward or forward.Write a
     function that checks if a given word is a palindrome.Character case is 
     significant.
     Example:
     word = "dabcbad"  returns true
     word = "Deed"  returns false (character cases differ)
     What is the algorithmic complexity("big O") of your function?
    */

    public class Task2
    {
        /// <summary>
        /// Test if string is palindrome
        /// This method has linear complexity O(n).
        /// </summary>
        /// <param name="word"></param>
        /// <returns>True if word is palindrome.</returns>
        public bool IsPalindrome(string word)
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
    }
}