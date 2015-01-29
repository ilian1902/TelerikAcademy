namespace TheBiggestOf3Numbers
{
    using System;

    class TheBiggestOfNumbers
    {
        // Write a program that finds the biggest of three numbers.

        static void Main()
        {
            Console.WriteLine("Enter 3 numbers:");
            Console.Write("First num = ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.Write("Second num = ");
            double secondNum = double.Parse(Console.ReadLine());
            Console.Write("Third num = ");
            double thirdNum = double.Parse(Console.ReadLine());
            if (firstNum > secondNum && firstNum > thirdNum)
            {
                Console.WriteLine("The biggest number is {0}", firstNum);
            }
            else if (secondNum > firstNum && secondNum > thirdNum)
            {
                Console.WriteLine("The biggest number is {0}", secondNum);
            }
            else if (thirdNum > firstNum && thirdNum > secondNum)
            {
                Console.WriteLine("The biggest number is {0}", thirdNum);
            }
            else
            {
                Console.WriteLine("The biggest number is {0}", firstNum);
            }
        }
    }
}
