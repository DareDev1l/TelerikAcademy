namespace Matrix
{
    using System;
    public class Matrix<T> where T : struct , IComparable
    {
        private T[,] matrix;

        // Constructors
        public Matrix()
        {
            this.matrix = new T[2,2];
        }

        // This constructor takes uint because uint can not be negative therefore no need for validation
        public Matrix(uint row , uint col) 
        {
            this.matrix = new T[row, col];
        }

        // Properties

        public int Rows
        {
            get { return this.matrix.GetLength(0); }
        }

        public int Cols
        {
            get { return this.matrix.GetLength(1); }
        }

        // Indexer
        public T this[int row , int col]
        {
            get { return this.matrix[row, col]; }
            set { this.matrix[row, col] = value; }
        }

        // Operator overloadings
        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            Matrix<T> result = new Matrix<T>((uint)m1.Rows, (uint)m1.Cols);
            if (m1.Rows != m2.Rows || m1.Cols != m2.Cols)
            {
                throw new InvalidOperationException("Cannot add matrices with different sizes");
            }
            else
            {
                for (int row = 0; row < m1.Rows; row++)
                {
                    for (int col = 0; col < m1.Cols; col++)
                    {
                        result[row, col] = (dynamic)m1[row, col] + m2[row, col];
                    }
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            Matrix<T> result = new Matrix<T>((uint)m1.Rows, (uint)m1.Cols);
            if (m1.Rows != m2.Rows || m1.Cols != m2.Cols)
            {
                throw new InvalidOperationException("Cannot add matrices with different sizes");
            }
            else
            {
                for (int row = 0; row < m1.Rows; row++)
                {
                    for (int col = 0; col < m1.Cols; col++)
                    {
                        result[row, col] = (dynamic)m1[row, col] - m2[row, col];
                    }
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Cols != m2.Rows)
            {
                throw new Exception("The matrices cannot be multiplied.");
            }

            Matrix<T> result = new Matrix<T>((uint)m1.Rows, (uint)m2.Cols);
            int temp;

            for (int matrixRow = 0; matrixRow < result.Rows; matrixRow++)
            {
                for (int matrixCol = 0; matrixCol < result.Cols; matrixCol++)
                {
                    temp = 0;
                    for (int index = 0; index < result.Cols; index++)
                    {
                        temp += (dynamic)m1[matrixRow, index] * m2[index, matrixCol];
                    }
                    result[matrixRow, matrixCol] = (dynamic)temp;
                }
            }

            return result;
        }

    }
}
