namespace LeapYear
{
    using System;

    class LeapYear
    {
        // Write a program that reads a year from the console and checks whether it is a leap one.
        // Use System.DateTime.

        static void Main()
        {
            Console.WriteLine("Enter year");
            int year = int.Parse(Console.ReadLine());
            bool leapYear = DateTime.IsLeapYear(year);
            Console.WriteLine("Is {0} year is leap? {1}",year, leapYear);
        }
        
    }
}
