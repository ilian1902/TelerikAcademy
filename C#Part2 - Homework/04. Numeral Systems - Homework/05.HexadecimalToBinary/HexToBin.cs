namespace HexadecimalToBinary
{
    using System;

    class HexToBin
    {
        // Write a program to convert hexadecimal numbers to binary numbers (directly).

        static void Main()
        {
            Console.Write("Enter Hexadecimal number = ");
            string hexaDecimalNum = Console.ReadLine();
            Console.WriteLine("Hexadecimal number {0} in Binary number is {1}", hexaDecimalNum, HexaDecimalToBinary(hexaDecimalNum));
        }
        static string HexaDecimalToBinary(string hexNum)
        {
            string binNum = "";
            int index = 0;
            for (int i = 0; i < hexNum.Length; i++)
            {
                index = hexNum[i] - 48;
                if (index > 9)
                {
                    index = index - 7;
                }
                binNum = binNum + Convert.ToString(index, 2).PadLeft(4, '0');
            }
            return binNum;
        }
    }
}
