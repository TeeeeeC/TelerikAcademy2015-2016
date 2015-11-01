namespace Refactoring
{
    using System;

    public class Matrix
    {
        private const int DirectionsCount = 8;
        private readonly int[] dirsX = { 0, -1, -1, -1, 0, 1, 1, 1 };
        private readonly int[] dirsY = { -1, -1, 0, 1, 1, 1, 0, -1 };
        private readonly int[,] matrix;

        private int size;
        
        public Matrix(int size)
        {
            this.Size = size;
            this.matrix = new int[this.Size, this.Size];
        }

        public int Size
        {
            get
            {
                return this.size;
            }

            set
            {
                if (value < 1 || 100 < value)
                {
                    throw new ArgumentOutOfRangeException(string.Format("The size of matrix must be between 1 and 100 inclusive!"));
                }

                this.size = value;
            }
        }

        public void Print()
        {
            var matrix = this.FindMatrixValues();
            for (int i = 0; i < this.Size; i++)
            {
                for (int j = 0; j < this.Size; j++)
                {
                    Console.Write(matrix[i, j].ToString().PadLeft(5, ' '));
                }

                Console.WriteLine();
            }
        }

        private int[,] FindMatrixValues()
        {
            var row = 0;
            var column = 0;
            var newRow = 0;
            var newColumn = 0;
            var oldRow = row;
            var oldColumn = column;
            var number = 1;
            var dx = 1;
            var dy = 1;

            while (this.CheckForEmptyCell(this.matrix))
            {
                do
                {
                    oldRow = row;
                    oldColumn = column;
                    this.matrix[row, column] = number;
                    row += dx;
                    column += dy;
                    number++;
                }
                while (this.InRange(this.matrix, row, column));

                row = oldRow;
                column = oldColumn;

                this.ChangeDirectionClockwise(this.matrix, row, column, out dx, out dy, out newRow, out newColumn);
                row = newRow;
                column = newColumn;
                row += dx;
                column += dy;
            }

            return this.matrix;
        }

        private void ChangeDirectionClockwise(int[,] matrix, int row, int column, out int dx, out int dy, out int newRow, out int newColumn)
        {
            dx = 0;
            dy = 0;
            newRow = 0;
            newColumn = 0;
            for (int i = 0; i < DirectionsCount; i++)
            {
                if (this.InRange(matrix, row + this.dirsX[i], column + this.dirsY[i]))
                {
                    dx = this.dirsX[i];
                    dy = this.dirsY[i];
                    newRow = row;
                    newColumn = column;
                    return;
                }
            }

            var emptyCellRow = 0;
            var emptyCellColumn = 0;
            if (this.FindEmptyCell(matrix, out emptyCellRow, out emptyCellColumn))
            {
                newRow = emptyCellRow;
                newColumn = emptyCellColumn;
            }
        }

        private bool InRange(int[,] matrix, int row, int column)
        {
            var inRange = 0 <= row && row < this.Size &&
                          0 <= column && column < this.Size && matrix[row, column] == 0;

            return inRange;
        }

        private bool CheckForEmptyCell(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    if (matrix[row, column] == 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool FindEmptyCell(int[,] matrix, out int newRow, out int newColumn)
        {
            newRow = 0;
            newColumn = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    if (matrix[row, column] == 0)
                    {
                        newRow = row;
                        newColumn = column;
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
