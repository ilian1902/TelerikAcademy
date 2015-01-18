namespace ExtractBitFromInteger
{
    using System;

    class ExtractBit
    {
        // Write an expression that extracts from given integer n the value of given bit at index p.

        static void Main()
        {
            Console.WriteLine("Enter integer \"N\"");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            Console.WriteLine("Enter position of Bit \"P\"");
            int bit = int.Parse(Console.ReadLine());
            int bitRight = number >> bit;
            int realbit = bitRight & 1;
            Console.WriteLine("Bit at position = " + realbit);
        }
    }
}
