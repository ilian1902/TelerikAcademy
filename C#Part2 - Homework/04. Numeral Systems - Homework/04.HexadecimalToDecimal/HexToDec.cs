namespace HexadecimalToDecimal
{
    using System;

    class HexToDec
    {
        // Write a program to convert hexadecimal numbers to their decimal representation.

        static void Main()
        {
            Console.Write("Enter Hexadecimal number = ");
            string hexaDecimalNum = Console.ReadLine();
            Console.WriteLine("Hexadecimal number {0} in decimal number is {1}", hexaDecimalNum, HexaDecimalToDecimal(hexaDecimalNum));
        }
        static long HexaDecimalToDecimal(string hexaDecimalNum)
        {
            long decimalNum = 0;
            
            for (int i = 0; i < hexaDecimalNum.Length; i++)
            {
                int digit = 0;
                int position = hexaDecimalNum.Length - i - 1;
                if (hexaDecimalNum[i] >= '0' && hexaDecimalNum[i] <= '9')
                {
                    digit = hexaDecimalNum[i] - '0';
                }
                else if (hexaDecimalNum[i] >= 'A' && hexaDecimalNum[i] <= 'F')
                {
                    digit = hexaDecimalNum[i] - 'A' + 10;
                }
                decimalNum += digit * (long)Math.Pow(16, position);
            }
            return decimalNum;
        }
    }
}
