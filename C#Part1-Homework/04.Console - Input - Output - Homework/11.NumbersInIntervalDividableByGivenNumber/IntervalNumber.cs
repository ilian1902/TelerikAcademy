namespace NumbersInIntervalDividableByGivenNumber
{
    using System;

    class IntervalNumber
    {
        // Write a program that reads two positive integer numbers and prints how many numbers p 
        // exist between them such that the reminder of the division by 5 is 0.

        static void Main()
        {
            Console.Write("Enter start number: ");
            int startNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter end number: ");
            int endNumber = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = startNumber; i <= endNumber; i++)
            {
                if (i % 5 == 0)
                {
                    result++;
                }
            }
            Console.WriteLine("P = {0}",result);
        }
    }
}
