using System.Collections.Generic;
using System.Linq;

namespace NetSuite
{
    /*
    3. Design a simple storage mechanism for sparse matrixes of integers(ie
    matrixes that have only very few non-zero elements but can be potentially
    large). Implement two methods on such matrixes:

    update matrix value at a given Row and column 
    void set(int Row, int Col, int val)

    return the sum of values from the top left corner to the given Row, column sub-matrix
    int sum(int Row, int Col)

    Assume all indices in the methods are zero-based.

    Example:

    Matrix A =
    (0  3  0  0 )
    ( 1  0  0  0 )
    ( 0  0  4  -1)
    ( 0  1  0  0 )

    set(0,1,5) on A =
    (0  5  0  0 )
    ( 1  0  0  0 )
    ( 0  0  4  -1)
    ( 0  1  0  0 )

    sum(2,2) on A = 8 =1+3+4
    */

    public class Task3
    {
        private readonly Dictionary<Index2D, int> SparseMatrix2D = new Dictionary<Index2D, int>();

        internal struct Index2D
        {
            internal int Col;
            internal int Row;
        }
        
        /// <summary>
        /// Update matrix value at a given Row and column
        /// </summary>
        public void Set(int row, int col, int val) => SparseMatrix2D[new Index2D() { Row = row, Col = col }] = val;

        /// <summary>
        /// Search sparse matrix for item at given coordinates.
        /// </summary>
        /// <param name="row">Row</param>
        /// <param name="col">column</param>
        /// <param name="res">result</param>
        /// <returns>True if item was found.</returns>
        public bool TryGet(int row, int col, out int res)
        {
            var index = new Index2D() { Row = row, Col = col };
            if (SparseMatrix2D.ContainsKey(index))
            {
                res = SparseMatrix2D[index];
                return true;
            }
            res = 0;
            return false;
        }

        /// <summary>
        /// Sum of values from the top left corner to the given Row, column sub-matrix
        /// </summary>
        public int Sum(int row, int col) => SparseMatrix2D.Where(x => x.Key.Row <= row && x.Key.Col <= col).Sum(x => x.Value);
    }
}
