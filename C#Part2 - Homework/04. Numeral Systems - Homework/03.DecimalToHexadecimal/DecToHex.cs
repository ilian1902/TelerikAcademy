namespace DecimalToHexadecimal
{
    using System;

    class DecToHex
    {
        // Write a program to convert decimal numbers to their hexadecimal representation.

        static void Main()
        {
            Console.Write("Enter Decimal number = ");
            long decimalNum = long.Parse(Console.ReadLine());
            Console.WriteLine("Decimal number {0} in hexadecimal number is {1}", decimalNum, DecimalToHexadecimal(decimalNum));
        }
        static string DecimalToHexadecimal(long decNum)
        {
            string hexadecNum = "";
            while (decNum > 0)
            {
                long digit = decNum % 16;
                if (digit >= 0 && digit <= 9)
                {
                    hexadecNum = (char)(digit + '0') + hexadecNum; 
                }
                else if (digit >= 10 && digit <= 15)
                {
                    hexadecNum = (char)(digit - 10 + 'A') + hexadecNum;
                }
                decNum = decNum / 16;
            }
            return hexadecNum;
        }
    }
}
