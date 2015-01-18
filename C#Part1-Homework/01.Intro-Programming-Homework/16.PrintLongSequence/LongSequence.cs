namespace PrintLongSequence
{
    using System;

    class LongSequence
    {
        /* Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
           You might need to learn how to use loops in C# (search in Internet).
         */

        static void Main()
        {
            for (int i = 1; i < 1001; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + ", ");
                }
                else
                {
                    Console.Write(- i + ", ");
                }
            }
            Console.WriteLine();
        }
    }
}
