namespace PointInsideACircleAndOutsideOfARectangle
{
    using System;

    class CircleRectangle
    {
        /* Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
           and out of the rectangle R(top=1, left=-1, width=6, height=2).
         */
        static void Main()
        {
            Console.Write("Enter point X = ");
            double pointX = double.Parse(Console.ReadLine());
            Console.Write("Enter point Y = ");
            double pointY = double.Parse(Console.ReadLine());
            double radius = 1.5 * 1.5;
            double top = 1;
            double left = -1;
            double right = 5;
            double down = -1;
            bool pointCircle = ((pointX - 1) * (pointX - 1) + (pointY - 1) * (pointY - 1)) <= radius;
            bool pointRectangle = ((left <= pointX) && (pointX <= right)) && ((down <= pointY) && (pointY <= top));
            if (pointCircle == true && pointRectangle == false)
            {
                Console.WriteLine("inside K and outside of R");
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("inside K and outside of R");
                Console.WriteLine("No");
            }
        }
    }
}
