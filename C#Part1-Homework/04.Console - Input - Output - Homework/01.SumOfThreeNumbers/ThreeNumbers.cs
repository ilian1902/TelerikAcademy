namespace SumOfThreeNumbers
{
    using System;

    class ThreeNumbers
    {
        // Write a program that reads 3 real numbers from the console and prints their sum.

        static void Main()
        {
            Console.Write("Please enter first integer number A = ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Please enter second integer number B = ");
            int secondNum = int.Parse(Console.ReadLine());
            Console.Write("Please enter thurd integer number C = ");
            int thirdNum = int.Parse(Console.ReadLine());
            int sumResult = firstNum + secondNum + thirdNum;
            Console.WriteLine("Sum of three integer numbers is {0}", sumResult);
        }
    }
}
