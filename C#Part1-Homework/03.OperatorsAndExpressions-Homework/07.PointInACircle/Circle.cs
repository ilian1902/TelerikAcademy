namespace PointInACircle
{
    using System;

    class Circle
    {
        // Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

        static void Main()
        {
            Console.Write("Enter point X = ");
            double pointX = double.Parse(Console.ReadLine());
            Console.Write("Enter point Y = ");
            double pointY = double.Parse(Console.ReadLine());
            int radius = 2;
            bool result = (pointX * pointX) + (pointY * pointY) <= radius * radius;
            Console.WriteLine(result);
        }
    }
}
