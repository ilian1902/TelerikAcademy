namespace NFactorial
{
    using System;
    using System.Numerics;

    class FactorialN
    {
        // Write a program to calculate n! for each n in the range [1..100].

        static void Main()
        {
            for (int i = 1; i <= 100; i++)
            {
                BigInteger factorial = Factorial(i);
                Console.WriteLine("Factorial {0} = {1}", i, factorial);
            }
        }
        static BigInteger Factorial(int num)
        {
            int currentNum = num;
            BigInteger factorial = 1;
            while (currentNum>1)
            {
                factorial *= currentNum;
                currentNum--;
            }
            return factorial;
        }
    }
}
