namespace Trapezoids
{
    using System;

    class TrapezoidsArea
    {
        // Write an expression that calculates trapezoid's area by given sides A and B and height H.

        static void Main()
        {
            Console.Write("Enter a said A = ");
            double sideA = double.Parse(Console.ReadLine());
            Console.Write("Enter a said B = ");
            double saidB = double.Parse(Console.ReadLine());
            Console.Write("Enter a height H = ");
            double heightH = double.Parse(Console.ReadLine());
            double areaS = ((sideA + saidB) * heightH) / 2;
            Console.WriteLine(areaS);
        }
    }
}
