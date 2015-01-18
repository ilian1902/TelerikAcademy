namespace CheckABitAtGivenPosition
{
    using System;

    class BitAtGivenPosition
    {
        // Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) 
        // in given integer number n, has value of 1.
        static void Main()
        {
            Console.WriteLine("Enter integer \"N\"");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            Console.WriteLine("Enter position of Bit \"P\"");
            int bitPosition = int.Parse(Console.ReadLine());
            int bitRight = number >> bitPosition;
            int realbit = bitRight & 1;
            bool chekBit;

            if (realbit == 1)
            {
                chekBit = true;
            }
            else
            {
                chekBit = false;
            }
            Console.WriteLine("Bit at position = {0} - {1}",realbit, chekBit);
        }
    }
}
