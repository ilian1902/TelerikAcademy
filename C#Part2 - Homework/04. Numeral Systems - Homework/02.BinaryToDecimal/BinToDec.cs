namespace BinaryToDecimal
{
    using System;

    class BinToDec
    {
        // Write a program to convert binary numbers to their decimal representation.

        static void Main()
        {
            Console.Write("Enter binary number = ");
            string binaryNum = Console.ReadLine();
            Console.WriteLine("Binary number {0} in decimal number is {1}", binaryNum, BinaryToDecimal(binaryNum));
        }
        static long BinaryToDecimal(string binNum)
        {
            long decNum = 0;
            for (int i = 0; i < binNum.Length; i++)
            {
                int digit = binNum[i] - '0';
                int position = binNum.Length - i - 1; // revers digit
                decNum += digit * (long)Math.Pow(2, position);
            }

            return decNum;
        }
    }
}
