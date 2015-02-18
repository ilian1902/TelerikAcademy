namespace SequenceNMatrix
{
    using System;

    class SequenceNMatrix
    {
        /* We are given a matrix of strings of size N x M. 
           Sequences in the matrix we define as sets of several neighbour elements located on the same line, 
           column or diagonal.
           Write a program that finds the longest sequence of equal strings in the matrix.
         */

        static void Main()
        {
            Console.Write("Enter size N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter size M = ");
            int m = int.Parse(Console.ReadLine());
            string[,] matrix = new string[n, m];

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write("Matrix[{0}, {1}]", row, col);
                    matrix[row, col] = Console.ReadLine();
                }
            }

            //printing
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + ", ");
                }
                Console.WriteLine();
            }

            // logik
            string search = "";
            int numMaxElement = 1;
            int numCurrentElement = 1;

            // compare down
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == matrix[row + 1, col])
                    {
                        numCurrentElement++;
                    }
                    if (numCurrentElement > numMaxElement)
                    {
                        numMaxElement = numCurrentElement;
                        search = matrix[row, col];
                    }
                }
            }
            // compare left
            numCurrentElement = 1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1])
                    {
                        numCurrentElement++;
                    }
                    if (numCurrentElement > numMaxElement)
                    {
                        numMaxElement = numCurrentElement;
                        search = matrix[row, col];
                    }
                }
            }
            //campare diagonal
            numCurrentElement = 1;
            for (int row = 0, col = 0; (row < n - 1) && (col < m - 1); row++, col++)
            {
                if (matrix[row, col] == matrix[row + 1, col + 1])
                {
                    numCurrentElement++;

                }
                if (numCurrentElement > numMaxElement)
                {
                    numMaxElement = numCurrentElement;
                    search = matrix[row, col];
                }
            }


            for (int i = 0; i < numMaxElement; i++)
            {
                Console.Write(search + " ");
            }
            Console.WriteLine();
        }
    }
}
