namespace Numbers_from1ToN
{
    using System;

    class OneToN
    {
        // Write a program that reads an integer number n from the console and prints all the numbers
        // in the interval [1..n], each on a single line.

        static void Main()
        {
            Console.Write("Enter number n = ");
            int numN = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numN; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
