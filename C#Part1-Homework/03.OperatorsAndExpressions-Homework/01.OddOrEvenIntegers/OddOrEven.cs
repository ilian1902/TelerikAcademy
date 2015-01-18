namespace OddOrEvenIntegers
{
    using System;

    class OddOrEven
    {
        // Write an expression that checks if given integer is odd or even.

        static void Main()
        {
            Console.WriteLine("Write number");
            string enter = Console.ReadLine();
            int number = int.Parse(enter);
            bool result = number % 2 != 0;
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
            Console.WriteLine(result);
        }
    }
}
