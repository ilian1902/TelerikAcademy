namespace ModifyABitAtGivenPosition
{
    using System;

    class ModifyABit
    {
        /* We are given an integer number n, a bit value v (v=0 or 1) and a position p.
           Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v 
           at the position p from the binary representation of n while preserving all other bits in n.
         */

        static void Main()
        {
            Console.Write("Please enter a number \nN = ");
            int numberN = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(numberN, 2).PadLeft(32, '0'));
            Console.Write("Please enter a position \nP = ");
            int positionP = int.Parse(Console.ReadLine());
            Console.Write("Please enter a value \"1\" or \"0\"\nV = ");
            int valueV = int.Parse(Console.ReadLine());
            numberN = numberN & (~(1 << positionP));
            Console.WriteLine(Convert.ToString(numberN, 2).PadLeft(32, '0'));
            numberN = numberN | (valueV << positionP);
            Console.WriteLine(Convert.ToString(numberN, 2).PadLeft(32, '0'));
            Console.WriteLine("New N = {0}", numberN);
        }
    }
}
