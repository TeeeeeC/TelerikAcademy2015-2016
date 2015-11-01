
using Refactoring;

namespace RefactoringTests
{
    using System;
    using System.IO;
    using NUnit.Framework;

    [TestFixture]
    public class MatrixTests
    {
        [TestCase(0)]
        [TestCase(101)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreatingMatrixWithSizeLessThan1andBiggerThan100ShouldThrowAnException(int size)
        {
            var matrix = new Matrix(size);
        }

        [TestCase(6)]
        [TestCase(16)]
        [TestCase(26)]
        [TestCase(36)]
        [TestCase(1)]
        public void PrintingMatrixShouldPrintProperlyResults(int number)
        {
            var matrix = new Matrix(number);

            Assert.DoesNotThrow(() => { matrix.Print(); });
        }
    }
}
