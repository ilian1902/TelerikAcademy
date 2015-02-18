namespace MaximalSum
{
    using System;

    class MaximalSum
    {
        // Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 
        // that has maximal sum of its elements.

        static void Main()
        {
            Console.Write("Enter size N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter size M = ");
            int m = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, m];

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write("Matrix[{0}, {1}]", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
            // printing
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }

            int sum = 0;
            int bestSum = 0;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                    }
                }
            }
            if (bestSum == 0)
            {
                Console.WriteLine("No squence 3 x 3 ");
            }
            else
            {
                Console.WriteLine("Best sum is = {0}", bestSum);
            }
        }
    }
}
