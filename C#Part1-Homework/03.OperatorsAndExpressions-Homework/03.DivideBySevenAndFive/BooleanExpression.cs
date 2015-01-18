namespace DivideBySevenAndFive
{
    using System;

    class BooleanExpression
    {
        // Write a Boolean expression that checks for given integer if it can be divided 
        // (without remainder) by 7 and 5 at the same time.

        static void Main()
        {
            Console.WriteLine("Enter integer number");
            int number = int.Parse(Console.ReadLine());
            bool expression = (number % 5 == 0) && (number % 7 == 0);
            if (number == 0)
            {
                expression = false;
            }
            Console.WriteLine(expression);
        }
    }
}
