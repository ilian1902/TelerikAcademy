namespace Sort3NumbersWithNestedIfs
{
    using System;

    class Sort3NumbersWithNestedIfs
    {
        // Write a program that enters 3 real numbers and prints them sorted in descending order.

        //Use nested if statements.

        static void Main()
        {
            Console.WriteLine("Enter 3 numbers");
            Console.Write("A = ");
            double aNum = double.Parse(Console.ReadLine());
            Console.Write("B = ");
            double bNum = double.Parse(Console.ReadLine());
            Console.Write("C = ");
            double cNum = double.Parse(Console.ReadLine());

            if (aNum >= bNum && aNum >= cNum)
            {
                if (bNum>=cNum)
                {
                    Console.WriteLine("{0}{1}{2}", aNum, bNum, cNum);
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}", aNum, cNum, bNum);
                }
            }
            else if (bNum >= aNum && bNum >= cNum)
            {
                if (aNum >= cNum)
                {
                    Console.WriteLine("{0}{1}{2}", bNum, aNum, cNum);
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}", bNum, cNum, aNum);
                }
            }
            else if (cNum >= aNum && cNum >= bNum)
            {
                if (bNum >= aNum)
                {
                    Console.WriteLine("{0}{1}{2}", cNum, bNum, aNum);
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}", cNum, aNum, bNum);
                }
            }
        }
    }
}
