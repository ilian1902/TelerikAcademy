namespace QuadraticEquation
{
    using System;

    class QuadraticEquation
    {
        /* Write a program that reads the coefficients a, b and c of a quadratic equation 
           ax2 + bx + c = 0 and solves it (prints its real roots).
         */
        static void Main()
        {
            Console.Write("Enter number a = ");
            double numA = double.Parse(Console.ReadLine());
            Console.Write("Enter number b = ");
            double numB = double.Parse(Console.ReadLine());
            Console.Write("Enter number c = ");
            double numC = double.Parse(Console.ReadLine());
            double discriminant = (numB * numB) - 4 * numA * numC;
            if (discriminant < 0)
            {
                Console.WriteLine("There are no real roots");
            }
            else
            {
                double discriminantRoot = Math.Sqrt(discriminant);
                double x2 = (-numB + discriminantRoot) / (2 * numA);
                double x1 = (-numB - discriminantRoot) / (2 * numA);
                Console.WriteLine(x1 == x2 ? "The Equasion got one real root x1 = {0}":"The Equasion got two real roots x1 = {0}; x2 = {1}"
                , x1, x2);
            }
        }
    }
}
