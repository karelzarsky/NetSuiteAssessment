using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace NetSuite
{
    /*
       1. Given an unsorted integer array, place all zeros to the end of the array
       without changing the sequence of non-zero elements.

       Example:

       list1 = [1, 3, 0, 8, 12, 0, 4, 0, 7] 
       return [1,3,8,12,4,7,0,0,0]

       What is the algorithmic complexity ("big O") of your function?
    */

    public static class Task1
    {
        /// <summary>
        /// Extension method.
        /// Place all zeros to the end of the array
        /// without changing the sequence of non-zero elements.
        /// </summary>
        /// <param name="array">unsorted integer array</param>
        public static void MoveZeroesToEndInplace(this int[] array)
        {
            int seekIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (++seekIndex >= array.Length) break;
                if (array[i] == 0)
                {
                    while (seekIndex < array.Length)
                    {
                        if (array[seekIndex] != 0) break;
                        seekIndex++;
                    }
                    array[i] = array[seekIndex];
                    array[seekIndex] = 0;
                }
            }
        }

        /// <summary>
        /// Extension method. Returns new array.
        /// Place all zeros to the end of the array
        /// without changing the sequence of non-zero elements.
        /// </summary>
        /// <param name="array">unsorted integer array</param>
        public static int[] MoveZeroesToEnd(this int[] array)
        {
            var result = new int[array.Length];
            int counter = 0;
            foreach (var x in array)
                if (x != 0) result[counter++] = x;
            return result;
        }
    }
}
