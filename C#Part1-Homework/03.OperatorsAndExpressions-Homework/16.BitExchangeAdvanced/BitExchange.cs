namespace BitExchangeAdvanced
{
    using System;

    class BitExchange
    {
        /* Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} 
           of a given 32-bit unsigned integer.
           The first and the second sequence of bits may not overlap.
         */

        static void Main()
        {
            int Number;
            int p;
            int q;
            int k;
            Console.WriteLine("Insert integer number n:");
            bool checkIntN = int.TryParse(Console.ReadLine(), out Number);
            Console.WriteLine("Insert number for first group bit position p:");
            bool checkIntP = int.TryParse(Console.ReadLine(), out p);
            Console.WriteLine("Insert number for second group bit position q:");
            bool checkIntQ = int.TryParse(Console.ReadLine(), out q);
            Console.WriteLine("Insert amount of bits k:");
            bool checkIntK = int.TryParse(Console.ReadLine(), out k);
            if (checkIntN == true && checkIntP == true && checkIntQ == true && checkIntK == true)
            {
                int maskP = 0;
                int mask;
                for (int i = 0; i < k; i++)
                {
                    mask = 1 << p + i;
                    maskP = maskP | mask;
                }
                int maskQ = 0;
                for (int i = 0; i < k; i++)
                {
                    mask = 1 << q + i;
                    maskQ = maskQ | mask;
                }
                int maskWithOne = maskP | maskQ;  
                maskWithOne = ~maskWithOne;

                maskP = Number & maskP;           
                maskQ = Number & maskQ;
                maskP = maskP >> p;               
                maskQ = maskQ >> q;
                maskP = maskP << q;               
                maskQ = maskQ << p;
                mask = maskQ | maskP;

                int result = Number & maskWithOne; 
                result = result | mask;             

                Console.WriteLine("n={0}({1})", Number, Convert.ToString(Number, 2).PadLeft(32, '0'));
                Console.WriteLine("n={0}({1})", result, Convert.ToString(result, 2).PadLeft(32, '0'));
            }
        }
    }
}
