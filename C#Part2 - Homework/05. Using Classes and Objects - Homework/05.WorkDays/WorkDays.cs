namespace WorkDays
{
    using System;
    using System.Linq;

    class WorkDays
    {
        /* Write a method that calculates the number of workdays between today and given date, 
           passed as parameter.
           Consider that workdays are all days from Monday to Friday except a fixed list of public holidays 
           specified preliminary as array.
         */

        static readonly DateTime[] holidays =
        {
        // Holidays dates
        new DateTime(2015, 1, 1), new DateTime(2015, 3, 3), new DateTime(2015, 4, 10),
        new DateTime(2015, 4, 13), new DateTime(2015, 5, 1), new DateTime(2015, 5, 6),
        new DateTime(2015, 5, 24), new DateTime(2015, 9, 6), new DateTime(2015, 9, 22),
        new DateTime(2015, 12, 24), new DateTime(2015, 12, 25)
        };

        static void Main()
        {
            DateTime dateNow = DateTime.Now;
            Console.Write("Enter day in future = ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Enter month in future = ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Enter year in future = ");
            int year = int.Parse(Console.ReadLine());
            DateTime userDate = new DateTime(year, month, day);
            Console.WriteLine("Workdays = {0}", CheckWorkingDays(dateNow, userDate));

        }

        private static int CheckWorkingDays(DateTime dateNow, DateTime futureDate)
        {
            int count = 0;
            if (dateNow > futureDate)
            {
                DateTime swap = dateNow;
                dateNow = futureDate;
                futureDate = swap;
            }
            while (dateNow <= futureDate)
            {
                if (!holidays.Contains(dateNow) && dateNow.DayOfWeek != DayOfWeek.Saturday && dateNow.DayOfWeek != DayOfWeek.Sunday)
                {
                    count++;
                }
                dateNow = dateNow.AddDays(1);
            }
            return count;
        }
    }
}
