namespace TheBiggestOfFiveNumbers
{
    using System;

    class TheBiggestOfFiveNumbers
    {
        // Write a program that finds the biggest of five numbers by using only five if statements.

        static void Main()
        {
            Console.WriteLine("Enter 5 numbers:");
            Console.Write("A num = ");
            double aNum = double.Parse(Console.ReadLine());
            Console.Write("B num = ");
            double bNum = double.Parse(Console.ReadLine());
            Console.Write("C num = ");
            double cNum = double.Parse(Console.ReadLine());
            Console.Write("D num = ");
            double dNum = double.Parse(Console.ReadLine());
            Console.Write("E num = ");
            double eNum = double.Parse(Console.ReadLine());
            if (aNum > bNum && aNum > cNum && aNum > dNum && aNum > eNum)
            {
                Console.WriteLine("The biggest number is {0}", aNum);
            }
            else if (bNum > aNum && bNum > cNum && bNum > dNum && bNum > eNum)
            {
                Console.WriteLine("The biggest number is {0}", bNum);
            }
            else if (cNum > aNum && cNum > bNum && cNum > dNum && cNum > eNum)
            {
                Console.WriteLine("The biggest number is {0}", cNum);
            }
            else if (dNum > aNum && dNum > bNum && dNum > cNum && dNum > eNum)
            {
                Console.WriteLine("The biggest number is {0}", dNum);
            }
            else if (eNum > aNum && eNum > bNum && eNum > cNum && eNum > dNum)
            {
                Console.WriteLine("The biggest number is {0}", eNum);
            }
            else
            {
                Console.WriteLine("The biggest number is {0}", aNum);
            }
        }
    }
}
