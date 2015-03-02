namespace SquareRoot
{
    using System;
   
    class SquareRoot
    {
        /* Write a program that reads an integer number and calculates and prints its square root.
           If the number is invalid or negative, print Invalid number.
           In all cases finally print Good bye.
           Use try-catch-finally block.
         */

        static void Main()
        {
            Console.WriteLine("Enter number");

            try
            {
                double number = double.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                Console.WriteLine(Math.Sqrt(number));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalit number!{0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye");
            }

        }
    }
}
