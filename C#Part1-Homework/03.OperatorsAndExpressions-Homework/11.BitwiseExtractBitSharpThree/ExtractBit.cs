namespace BitwiseExtractBitSharpThree
{
    using System;

    class ExtractBit
    {
        /* Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
           The bits are counted from right to left, starting from bit #0.
           The result of the expression should be either 1 or 0.
         */

        static void Main()
        {
            int enterNum = int.Parse(Console.ReadLine());
            int p = 3;
            int mask = 1 << p;
            int resultBit = mask & enterNum;
            int bit = resultBit >> p;
            Console.WriteLine("Third bit is" + " " + bit);
            Console.WriteLine(Convert.ToString(enterNum, 2).PadLeft(32, '0'));
        }
    }
}
