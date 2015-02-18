namespace FillTheMatrix
{
    using System;

    class FillTheMatrix
    {
        // Write a program that fills and prints a matrix of size (n, n) as shown below:

        static void Main()
        {
            Console.Write("Enter number n = ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            int num = 1;

            //  a)
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[col, row] = num;
                    num++;
                }
            }

            // Printing a)
            Console.WriteLine("Matrix A:");
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    Console.Write("{0, 4}", matrix[row, col]);
                }
                Console.WriteLine();
            }

            num = 1;
            Console.WriteLine();


            // b)
            for (int col = 0; col < n; col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < n; row++)
                    {
                        matrix[row, col] = num;
                        num++;
                    }
                }
                else
                {
                    for (int row = n - 1; row >= 0; row--)
                    {
                        matrix[row, col] = num;
                        num++;
                    }
                }
            }
            // Printing b)
            Console.WriteLine("Matrix B:");
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0, 4}", matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            num = 1;

            // c)
            for (int i = n - 1; i >= 0; i--)
            {
                int row = i;
                int col = 0;
                while (row < n && col < n)
                {
                    matrix[row, col] = num;
                    row++;
                    col++;
                    num++;
                }
            }
            for (int i = 1; i < n; i++)
            {
                int row = 0;
                int col = i;
                while (row < n && col < n)
                {
                    matrix[row, col] = num;
                    row++;
                    col++;
                    num++;
                }
            }
            // printing c)
            Console.WriteLine("Matrix C:");
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0, 4}", matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            // d)



            // clear matrix
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = 0;
                }
            }
            num = 1;
            int cols = 0;
            int rows = 0;
            string direction = "down";
            while (num <= n*n)
            {


                if (direction == "down")
                {
                    matrix[rows, cols] = num;
                    rows++;
                    if (rows > matrix.GetLength(0) - 1 || matrix[rows, cols] != 0)
                    {
                        direction = "right";
                        rows--;
                    }
                }
                if (direction == "right")
                {

                    matrix[rows, cols] = num;
                    cols++;
                    if (cols > matrix.GetLength(1) - 1 || matrix[rows, cols] != 0)
                    {
                        direction = "up";
                        cols--;
                    }
                }
                if (direction == "up")
                {
                    matrix[rows, cols] = num;
                    rows--;
                    if (0 > rows || matrix[rows, cols] != 0)
                    {
                        direction = "left";
                        rows++;
                    }
                }
                if (direction == "left")
                {
                    matrix[rows, cols] = num;
                    cols--;
                    if (cols < 0 || matrix[rows, cols] != 0)
                    {
                        direction = "down";
                        cols++;

                    }

                }
                num++;
            }

            // printing d)
            Console.WriteLine("Matrix D:");
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0, 4}", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}

