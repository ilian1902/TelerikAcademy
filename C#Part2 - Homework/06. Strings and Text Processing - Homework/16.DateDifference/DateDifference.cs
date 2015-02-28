namespace DateDifference
{
    using System;
    using System.Globalization;

    class DateDifference
    {
        /* Write a program that reads two dates in the format: 
           day.month.year and calculates the number of days between them.
          Example:

            Enter the first date: 27.02.2006
            Enter the second date: 3.03.2006
            Distance: 4 days
         */

        static void Main()
        {
            Console.WriteLine("Date format example: dd.MM.yyyy or dd/MM/yyyy");
            Console.Write("Enter first date = ");
            string[] DateUser = { "dd.MM.yyyy", "d.MM.yy", "dd.M.yyyy", "d.M.yyyy", "dd/MM/yyyy", "d/MM/yy", "dd/M/yyyy", "d/M/yyyy" };
            DateTime firstDate;
            DateTime.TryParseExact(Console.ReadLine(), DateUser, CultureInfo.InvariantCulture, DateTimeStyles.None, out firstDate);
            Console.Write("Enter second date = ");
            DateTime secondDate;
            DateTime.TryParseExact(Console.ReadLine(), DateUser, CultureInfo.InvariantCulture, DateTimeStyles.None, out secondDate);
            int distance = (secondDate - firstDate).Days;
            
            Console.WriteLine("First date = {0: dd.MM.yyyy}", firstDate);
            Console.WriteLine("Second date = {0: dd.MM.yyyy}", secondDate);
            Console.WriteLine("Distance = {0} days", distance);

        }
    }
}
