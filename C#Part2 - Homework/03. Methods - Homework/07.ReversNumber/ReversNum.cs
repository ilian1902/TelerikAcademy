namespace ReversNumber
{
    using System;

    class ReversNum
    {
        // Write a method that reverses the digits of given decimal number.

        static void Main()
        {
            Console.WriteLine("Enter number");
            double userNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Your revers number is {0}", ReversNumbers(userNum));
        }
        static double ReversNumbers(double revers)
        {
            char[] chr = revers.ToString().ToCharArray();
            Array.Reverse(chr);
            return double.Parse(new string(chr));
        }
    }
}
