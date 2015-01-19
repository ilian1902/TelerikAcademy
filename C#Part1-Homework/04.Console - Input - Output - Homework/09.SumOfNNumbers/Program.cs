namespace SumOfNNumbers
{
    using System;

    class Program
    {
        // Write a program that enters a number n and after that enters more n numbers 
        // and calculates and prints their sum. Note: You may need to use a for-loop.

        static void Main()
        {
            Console.Write("Enter how many numbers You will enter: ");
            double numN = double.Parse(Console.ReadLine());
            double sum = 0;
            for (double i = 1; i <= numN; i++)
            {
                Console.WriteLine("Enter the {0} number", i);
                double numI = double.Parse(Console.ReadLine());
                sum += numI;
            }
            Console.WriteLine("Sum is {0}",sum);
        }
    }
}
