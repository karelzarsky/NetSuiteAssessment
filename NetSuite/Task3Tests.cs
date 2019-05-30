using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NetSuiteAssessment
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

    [TestClass]
    public class Task3Tests
    {
        public Task3 CreateMatrixA()
        {
            var res = new Task3();
            res.Set(0, 1, 3);
            res.Set(1, 0, 1);
            res.Set(2, 2, 4);
            res.Set(2, 3, -1);
            res.Set(0, 3, 1);
            return res;
        }

        [TestMethod]
        public void MatrixSetTest()
        {
            var matrixA = CreateMatrixA();
            matrixA.TryGet(0, 1, out int result);
            Assert.AreEqual(3, result);
            matrixA.Set(0, 1, 5);
            matrixA.TryGet(0, 1, out result);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void MatrixSumTest()
        {
            var matrixA = CreateMatrixA();
            int sum = matrixA.Sum(2, 2);
            Assert.AreEqual(8, sum);
        }
    }
}