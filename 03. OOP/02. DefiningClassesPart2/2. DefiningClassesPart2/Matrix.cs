namespace _2.DefiningClassesPart2
{
    using System;

    public class Matrix<T> where T : struct
    {
        private const int Rows = 2;
        private const int Cols = 2;

        private T[,] data;
        private int lengthRows;
        private int lengthCols;

        public Matrix()
            : this(Rows, Cols)
        {
            this.lengthRows = Rows;
            this.lengthCols = Cols;
        }

        public Matrix(int rows, int cols)
        {
            if (rows < 1 || cols < 1)
            {
                throw new ArgumentOutOfRangeException("Initial size must be bigger than 0!");
            }
            this.data = new T[rows, cols];
            this.lengthRows = rows;
            this.lengthCols = cols;
        }

        public T this[int row, int col]
        {
            get
            {
                if (row >= 0 && row < this.lengthRows && col >= 0 && col < this.lengthCols)
                {
                    return this.data[row, col];
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Index out of range!");
                }
            }
            set
            {
                this.data[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.lengthRows != secondMatrix.lengthRows || firstMatrix.lengthCols != secondMatrix.lengthCols)
            {
                throw new ArgumentOutOfRangeException("Matrices must be with the same sizes!");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.lengthRows, firstMatrix.lengthCols);
            for (int row = 0; row < firstMatrix.lengthRows; row++)
            {
                for (int col = 0; col < firstMatrix.lengthCols; col++)
                {
                    result[row, col] = (dynamic)firstMatrix[row, col] + secondMatrix[row, col];
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.lengthRows != secondMatrix.lengthRows || firstMatrix.lengthCols != secondMatrix.lengthCols)
            {
                throw new ArgumentOutOfRangeException("Matrices must be with the same sizes!");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.lengthRows, firstMatrix.lengthCols);
            for (int row = 0; row < firstMatrix.lengthRows; row++)
            {
                for (int col = 0; col < firstMatrix.lengthCols; col++)
                {
                    result[row, col] = (dynamic)firstMatrix[row, col] - secondMatrix[row, col];
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.lengthRows != secondMatrix.lengthRows || firstMatrix.lengthCols != secondMatrix.lengthCols)
            {
                throw new ArgumentOutOfRangeException("Matrices must be with the same sizes!");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.lengthRows, firstMatrix.lengthCols);
            for (int row = 0; row < firstMatrix.lengthRows; row++)
            {
                for (int col = 0; col < firstMatrix.lengthCols; col++)
                {
                    result[row, col] = (dynamic)firstMatrix[row, col] * secondMatrix[row, col];
                }
            }

            return result;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if(matrix[i, j] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public int GetLength(int index)
        {
            if (index == 0)
                return this.lengthRows;
            else if (index == 1)
                return this.lengthCols;

            throw new ArgumentOutOfRangeException("Index out of range!");
        }


    }
}
