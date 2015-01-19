namespace SumOf5Numbers
{
    using System;

    class SumOfNumbers
    {
        /*Write a program that enters 5 numbers (given in a single line, separated by a space), 
          calculates and prints their sum.
         */
        static void Main()
        {
            Console.WriteLine("Enter five numbers given in a single line, separated by a space");
            string [] fiveNum = Console.ReadLine().Split(' ');
            double sum = 0;
            for (int i = 0; i < fiveNum.Length; i++)
            {
                sum += Convert.ToDouble(fiveNum[i]);
            }
            Console.WriteLine("Sum is = {0}", sum);
        }
    }
}
