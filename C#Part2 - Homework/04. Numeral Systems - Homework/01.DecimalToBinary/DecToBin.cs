namespace DecimalToBinary
{
    using System;

    class DecToBin
    {
        // Write a program to convert decimal numbers to their binary representation.

        static void Main()
        {
            Console.Write("Enter Decimal number = ");
            long decimalNum = long.Parse(Console.ReadLine());
            Console.WriteLine("Decimal number {0} in binary number is {1}", decimalNum, DecimalToBinary(decimalNum));
        }
        static string DecimalToBinary(long decNum)
        {
            string bineryNumber = "";
            while (decNum > 0)
            {
                long digit = decNum % 2;
                bineryNumber = digit + bineryNumber;
                decNum = decNum / 2;
                
            }
            return bineryNumber;
        }
    }
}
