namespace CirclePerimeterAndArea
{
    using System;

    class Circle
    {
        //Write a program that reads the radius r of a circle and prints its perimeter and area formatted 
        //with 2 digits after the decimal point.

        static void Main()
        {
            Console.WriteLine("Please enter radios \"R\" of circle");
            double radiosR = double.Parse(Console.ReadLine());
            double areaCircle = (radiosR * radiosR) * Math.PI;
            double perimeterCircle = (Math.PI * radiosR) * 2;
            Console.WriteLine("Area of circle is {0}\nPerimeter of circle is {1}", areaCircle, perimeterCircle);
        }
    }
}
