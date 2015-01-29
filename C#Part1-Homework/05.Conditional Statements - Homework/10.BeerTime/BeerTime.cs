namespace BeerTime
{
    using System;

    class BeerTime
    {
        /* A beer time is after 1:00 PM and before 3:00 AM.
           Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], 
           a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time 
           according to the definition above or invalid time if the time cannot be parsed. 
           Note: You may need to learn how to parse dates and times.
         */

        static void Main()
        {
            Console.WriteLine("Enters a time in format \"hh:mm tt\" Exam: 1:23PM");
            DateTime user = DateTime.Parse(Console.ReadLine());
            DateTime finalBeerTime = DateTime.Parse("3:00AM");
            DateTime startBeerTime = DateTime.Parse("1:00PM");

            if (user < startBeerTime && user >= finalBeerTime)
            {
                Console.WriteLine("non-beer time");
            }
            else
            {
                Console.WriteLine("beer time");
            }
        }
    }
}
