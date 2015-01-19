namespace FibonacciNumbers
{
    using System;
    using System.Numerics;

    
    

    class Fibonacci
    {
        /* Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
           (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …
         */
        static void Main()
        {
            Console.Write("Enter number n = ");
            BigInteger numN = BigInteger.Parse(Console.ReadLine());
            BigInteger firstNum = 0;
            BigInteger secondNum = 1;
            BigInteger sum;

            for (int i = 0; i < numN; i++)
            {
                Console.WriteLine("{0}",firstNum);
                sum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = sum;
            }
        }
    }
}
