namespace TriangleSurface
{
    using System;

    class TriangleSurface
    {
        /* Write methods that calculate the surface of a triangle by given:
            Side and an altitude to it;
            Three sides;
            Two sides and an angle between them;
           Use System.Math.
         */

        static void Main()
        {
            Console.WriteLine("Enter three side in triangle.");
            Console.Write("Side A = ");
            decimal sideA = decimal.Parse(Console.ReadLine());
            Console.Write("Side B = ");
            decimal sideB = decimal.Parse(Console.ReadLine());
            Console.Write("Side C = ");
            decimal sideC = decimal.Parse(Console.ReadLine());
            decimal angleAB = sideA * sideB;
            decimal heightToSideA = sideC;
            decimal areas;

            areas = ThreeSides(sideA, sideB, sideC);
            Console.WriteLine("Three sides = {0:F1}", areas);
            areas = TwoSideAndAngle(sideA, sideB, angleAB);
            Console.WriteLine("Two sides and angle = {0:F1}", areas);
            areas = HeightAndSide(sideA, heightToSideA);
            Console.WriteLine("Height and side = {0:F1}", areas);
        }

        static decimal HeightAndSide(decimal sideA, decimal heightSideA)
        {
            return (sideA * heightSideA) / 2.0m;
        }

        static decimal TwoSideAndAngle(decimal sideA, decimal sideB, decimal angleAB)
        {
            angleAB = angleAB * (decimal)Math.PI / 180;
            return ((decimal)Math.Sin((double)angleAB) * sideA * sideB) / 2.0m;
        }

        static decimal ThreeSides(decimal sideA, decimal sideB, decimal sideC)
        {
            decimal p = (sideA + sideB + sideC) / 2;
            return (decimal)Math.Sqrt((double)(p * (p - sideA) * (p - sideB) * (p - sideC)));
        }

    }
}
