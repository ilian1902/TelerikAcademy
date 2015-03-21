namespace DefiningClassesPartTwoProblem8910
{
    using System;

    //Problem 8 Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 
    public class Matrix<T> where T : IComparable
    {
        private int row;
        private int col;
        private T[,] matrix;

        public Matrix(int rowMatrix, int colMatrix)
        {
            this.Row = rowMatrix;
            this.Col = colMatrix;
            this.matrix = new T[this.Row, this.Col];
        }

        public int Row
        {
            get
            {
                return this.row;
            }
            set
            {
                if (value > 0 && value < int.MaxValue)
                {
                    this.row = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Rows cant be negative or more than int.MaxValue!");
                }
            }
        }

        public int Col
        {
            get
            {
                return this.col;
            }
            set
            {
                if (value > 0 && value < int.MaxValue)
                {
                    this.col = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Cols cant be negative or more than int.MaxValue!");
                }
            }
        }

        public T this[int rowMatrix, int colMatrix]// Problem 9 Implement an indexer this[row, col] to access the inner matrix cells.
        {
            get
            {
                return this.matrix[rowMatrix, colMatrix];
            }
            set
            {
                if (rowMatrix >= 0 && rowMatrix <= int.MaxValue && colMatrix >= 0 && colMatrix <= int.MaxValue)
                {
                    this.matrix[rowMatrix, colMatrix] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)// Problem 10
        {
            if (m1.Row != m2.Row || m1.Col != m2.Col)
            {
                throw new ArgumentException("Matrices must be with the same length ot rows and cols!");
            }
            int currentRows = m1.Row;
            int currentCols = m1.Col;
            Matrix<T> current = new Matrix<T>(currentRows, currentCols);
            for (int row = 0; row < current.Row; row++)
            {
                for (int col = 0; col < current.Col; col++)
                {
                    dynamic m1CurrentVal = m1[row, col];
                    dynamic m2CurrentVal = m2[row, col];
                    current[row, col] = m1CurrentVal + m2CurrentVal;
                }
            }
            return current;
        }

        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)// Problem 10
        {
            if (m1.Row != m2.Row || m1.Col != m2.Col)
            {
                throw new ArgumentException("Matrices must be with the same length ot rows and cols!");
            }
            int currentRows = m1.Row;
            int currentCols = m1.Col;
            Matrix<T> current = new Matrix<T>(currentRows, currentCols);
            for (int row = 0; row < current.Row; row++)
            {
                for (int col = 0; col < current.Col; col++)
                {
                    dynamic m1CurrentVal = m1[row, col];
                    dynamic m2CurrentVal = m2[row, col];
                    current[row, col] = m1CurrentVal - m2CurrentVal;
                }
            }
            return current;
        }

        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)// Problem 10
        {
            if (m1.Row != m2.Row || m1.Col != m2.Col)
            {
                throw new ArgumentException("Matrices must be with the same length ot rows and cols!");
            }
            T val;
            int currentRows = m1.Row;
            int currentCols = m1.Col;
            Matrix<T> current = new Matrix<T>(currentRows, currentCols);
            for (int i = 0; i < current.Row; i++)
            {
                for (int j = 0; j < current.Col; j++)
                {
                    val = (dynamic)0;
                    for (int k = 0; k < current.Col; k++)
                    {
                        dynamic m1CurrentVal = m1[i, k];
                        dynamic m2CurrentVal = m2[i, j];
                        val += m1CurrentVal * m2CurrentVal;
                    }
                    current[i, j] = (dynamic)val;
                }
            }
            return current;
        }

        public static bool operator true(Matrix<T> m1)// Problem 10
        {
            bool doesContainZeroElements = false;
            for (int row = 0; row < m1.Row; row++)
            {
                for (int col = 0; col < m1.Col; col++)
                {
                    if (m1[row, col].Equals(default(T)))
                    {
                        doesContainZeroElements = true;
                        break;
                    }
                }
            }
            return doesContainZeroElements;
        }

        public static bool operator false(Matrix<T> m1)// Problem 10
        {
            bool doesContainZeroElements = true;
            for (int row = 0; row < m1.Row; row++)
            {
                for (int col = 0; col < m1.Col; col++)
                {
                    if (m1[row, col].Equals(default(T)))
                    {
                        doesContainZeroElements = false;
                    }
                    else
                    {
                        doesContainZeroElements = true;
                    }
                }
            }
            return doesContainZeroElements;
        }

        public override string ToString()
        {
            return this.ToString();
        }
    }
}
