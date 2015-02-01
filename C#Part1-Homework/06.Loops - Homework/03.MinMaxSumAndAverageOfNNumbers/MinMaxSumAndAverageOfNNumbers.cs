namespace MinMaxSumAndAverageOfNNumbers
{
    using System;

    class MinMaxSumAndAverageOfNNumbers
    {
        /* Write a program that reads from the console a sequence of n integer numbers and returns the minimal, 
           the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
           The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
           The output is like in the examples below.
         */

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;
            int min = int.MaxValue;
            int number;
            
            
            for (int i = 0; i < n; i++)
            {
                 number = int.Parse(Console.ReadLine());
                
                sum += number;
                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }
            }
            double avg = (double)sum / (double)n;
            Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3:F2}", min, max, sum, avg);
        }
    }
}
