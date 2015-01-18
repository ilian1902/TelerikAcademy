namespace PrimeNumberCheck
{
    using System;

    class IsPrime
    {
        /* Write an expression that checks if given positive integer number n (n = 100) is prime 
           (i.e. it is divisible without remainder only to itself and 1).
         */
        static void Main()
        {
            Console.Write("Enter a number N = ");
            int numberN = int.Parse(Console.ReadLine());
            double root = Math.Sqrt(numberN);
            bool primeTest = true;
            for (int i = 2; i <= root; i++)
            {
                if (numberN % i == 0)
                {
                    primeTest = false;
                }
            }
            if (numberN == 1 || numberN <= 0)
            {
                primeTest = false;
            }
            Console.WriteLine("{0} is prime - {1}", numberN, primeTest);
        }
    }
}
