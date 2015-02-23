namespace DayOfWeek
{
    using System;

    class DayOfWeek
    {
        // Write a program that prints to the console which day of the week is today.
        // Use System.DateTime.

        static void Main()
        {
            string[] weeks = {"Monday",
                              "Tuesday",
                              "Wednesday",
                              "Thursday",
                              "Friday",
                              "Saturday",
                              "Sunday"};

            DateTime dayNow = new DateTime();
            int day = (int)dayNow.DayOfWeek;
            
            Console.WriteLine("Today is {0}", weeks[day-1]);

        }
    }
}
