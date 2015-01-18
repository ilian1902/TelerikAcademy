namespace ThirdDigitIsSeven
{
    using System;

    class ThirdDigit
    {
        // Write an expression that checks for given integer if its third digit from right-to-left is 7.

        static void Main()
        {
            Console.WriteLine("Enter number \"N\"");
            int numberN = int.Parse(Console.ReadLine());
            bool result = (numberN / 100) % 10 == 7;
            Console.WriteLine("Third digit right to left is 7 \n{0}", result);
        }
    }
}
