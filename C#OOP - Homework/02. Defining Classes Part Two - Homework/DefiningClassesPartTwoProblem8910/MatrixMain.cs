namespace DefiningClassesPartTwoProblem8910
{
    using System;

    public class MatrixMain
    {
        public static void Main()
        {
            Matrix<double> matrixOfDouble = new Matrix<double>(3, 1);
            matrixOfDouble[0, 0] = 20;
            matrixOfDouble[1, 0] = 553.3;
            matrixOfDouble[2, 0] = 2222;
            
            Matrix<int> firstMatrix = new Matrix<int>(2, 2);
            firstMatrix[0, 0] = 5;
            firstMatrix[1, 0] = 20;
            firstMatrix[0, 1] = 1;
            firstMatrix[1, 1] = 4;

            Matrix<int> secondMatrix = new Matrix<int>(2, 2);
            secondMatrix[0, 0] = 1;
            secondMatrix[1, 0] = 5;
            secondMatrix[0, 1] = 7;
            secondMatrix[1, 1] = 9;

            Console.WriteLine("Matrix 3 has {0} rows and {1} cols", firstMatrix.Row, firstMatrix.Col);
            Matrix<int> matrixPlus = firstMatrix + secondMatrix;
            Matrix<int> matrixMinus = firstMatrix - secondMatrix;
            Matrix<int> matrixMultiplied = firstMatrix * secondMatrix;
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("---- Matrices addition: ");
            Console.WriteLine();
            for (int row = 0; row < matrixPlus.Row; row++)
            {
                for (int col = 0; col < matrixPlus.Col; col++)
                {
                    Console.WriteLine("Matrix 3 addited with matrix 4 values -> {0}", matrixPlus[row, col]);
                }
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("---- Matrices substraction: ");
            Console.WriteLine();
            for (int row = 0; row < matrixMinus.Row; row++)
            {
                for (int col = 0; col < matrixMinus.Col; col++)
                {
                    Console.WriteLine("Matrix 3 substracted with matrix 4 values -> {0}", matrixMinus[row, col]);
                }
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("---- Matrices multiplication: ");
            Console.WriteLine();
            for (int row = 0; row < matrixMultiplied.Row; row++)
            {
                for (int col = 0; col < matrixMultiplied.Col; col++)
                {
                    Console.WriteLine("Matrix 3 multiplied by matrix 4 values -> {0}", matrixMultiplied[row, col]);
                }
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 20));
            if (matrixOfDouble)
            {
                Console.WriteLine("Matrix 1 contains zero elements!");
            }
            else
            {
                Console.WriteLine("Matrix 1 does not contain any zero elements!");
            }
        }
    }
}
