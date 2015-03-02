namespace EnterNumbers
{
    using System;

    class EnterNumbers
    {
        /* 
    Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
        If an invalid number or non-number text is entered, the method should throw an exception.
    Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
         */

        static void Main()
        {
            try
            {
                Console.WriteLine("Enter start number: ");
                int start = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter end number: ");
                int end = int.Parse(Console.ReadLine());
                ReadNumber(start, end);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch (ArgumentOutOfRangeException ie)
            {
                Console.WriteLine("Error " + ie.Message);
            }
        }

        static void ReadNumber(int start, int end)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter number > start and number < end");
                int numb = int.Parse(Console.ReadLine());
                if (numb < start || numb > end)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}
